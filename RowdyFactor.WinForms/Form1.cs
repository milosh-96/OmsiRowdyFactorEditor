﻿using RowdyFactor.Processing;
using RowdyFactor.Processing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowdyFactor.WinForms
{
    public partial class MainForm : Form
    {
        private int bufferCount;

        public int BufferCount
        {
            get { return bufferCount; }
            set { bufferCount = value;if (value > 0) { writeChangesButton.Enabled = true;this.Refresh(); } else { writeChangesButton.Enabled = false;this.Refresh(); } }
        }

        string omsiDirectory = null;
        List<OmsiVehicle> vehicles = new List<OmsiVehicle>();
        int currentVehicleIndex;

        public MainForm()
        {
            InitializeComponent();
            writeChangesButton.Enabled = false;
            selectAiListFileButton.Enabled = false;
            saveVehicleButton.Enabled = false;
            rowdyNumberEditorGroupBox.Hide();
           
           
        }

        private void selectAiListFileButton_Click(object sender, EventArgs e)
        {
            vehicles.Clear();
            aiListListView.Items.Clear();
            openFileDialog1.Title = "Select the AI list (ailists.cfg) file";
            openFileDialog1.InitialDirectory = omsiDirectory + "\\maps";
            openFileDialog1.FileName = "ailists.cfg";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                saveVehicleButton.Enabled = true;
                string[] fileContents = File.ReadAllLines(openFileDialog1.FileName, Encoding.GetEncoding("iso-8859-1"));
                List<string> vehiclePaths = AiListsParser.ExtractAllVehicles(fileContents);


                vehiclePaths.ForEach(x =>
                {
                    OmsiVehicle vehicle = new OmsiVehicle();
                    vehicle = new FileHandler().Process($"{omsiDirectory}/{x}");
                    if (!vehicle.InvalidVehicle)
                    {
                        vehicles.Add(vehicle);
                    }
                });



                // set full width of items //
                // fill listview with items with vehicles
                vehicles.ForEach(x => {
                    string filename = Path.GetFileName(x.FilePath);
                    ListViewItem item = new ListViewItem() {
                        Text = $"{x.Name.Brand} {x.Name.CarModel} ({filename})",
                        Tag = x,
                        ToolTipText = x.FilePath,
                        
                    };
                    aiListListView.Items.Add(item);
                });

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SelectOmsiFolderDialog();
        }

        private void SelectOmsiFolderDialog()
        {
            folderBrowserDialog1.Description = "Select the main (root) OMSI 2 folder. You should see Omsi.exe, maps, vehicles and some other folders.";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                omsiDirectory = folderBrowserDialog1.SelectedPath;
                currentOmsiDirectoryLabel.Text = omsiDirectory;
                selectAiListFileButton.Enabled = true;
                selectChangeOmsiDirButton.Visible = false;
            }
            else
            {
                omsiDirectory = null;
                currentOmsiDirectoryLabel.Text = omsiDirectory ?? "OMSI 2 main folder isn't selected!";
                MessageBox.Show("The Folder isn't selected!");
            }
        }

        private void aiListListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            OmsiVehicle item = (OmsiVehicle)e.Item.Tag;
            currentVehicleIndex = vehicles.IndexOf(item);
            if (item.RowdyFactor != null &&
                item.RowdyFactor.From.HasValue &&
                item.RowdyFactor.To.HasValue
                )
            {
                fromRowdyNumberInput.Value = (decimal)item.RowdyFactor.From.Value;
                toRowdyNumberInput.Value = (decimal)item.RowdyFactor.To.Value;
                rowdyNumberEditorGroupBox.Show();
            }
            else
            {
                MessageBox.Show("This vehicle is invalid or doesn't have a rowdy factor entry.");
            }
        }

        private void saveVehicleButton_Click(object sender, EventArgs e)
        {
            vehicles[currentVehicleIndex].RowdyFactor.From = (double)fromRowdyNumberInput.Value;
            vehicles[currentVehicleIndex].RowdyFactor.To = (double)toRowdyNumberInput.Value;
            vehicles[currentVehicleIndex].RowdyFactor.Modified = true;
            writeChangesButton.Enabled = true;
            bufferCount++;
        }

        private void writeChangesButton_Click(object sender, EventArgs e)
        {
            foreach(OmsiVehicle vehicle in vehicles)
            {
                if (vehicle.RowdyFactor != null && vehicle.RowdyFactor.Modified)
                {
                    new FileHandler().WriteRowdyFactor(vehicle);
                    vehicle.RowdyFactor.Modified = false;
                }
            }
            MessageBox.Show("Done");
            writeChangesButton.Enabled = false;
        }

        private void selectChangeOmsiDirButton_Click(object sender, EventArgs e)
        {
            SelectOmsiFolderDialog();
        }
    }
}
