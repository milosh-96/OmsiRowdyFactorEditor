using RowdyFactor.Processing;
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
        string omsiDirectory = null;
        List<OmsiVehicle> vehicles = new List<OmsiVehicle>();
        int currentVehicleIndex;

        public MainForm()
        {
            InitializeComponent();
            writeChangesButton.Enabled = false;
            selectAiListFileButton.Enabled = false;
            rowdyNumberEditorGroupBox.Hide();
           
           
        }

        private void selectAiListFileButton_Click(object sender, EventArgs e)
        {
            vehicles.Clear();
            aiListListView.Items.Clear();
            openFileDialog1.InitialDirectory = omsiDirectory + "\\maps";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string[] fileContents = File.ReadAllLines(openFileDialog1.FileName, Encoding.GetEncoding("iso-8859-1"));
                List<string> vehiclePaths = AiListsParser.ExtractAiGroup("NormalCars", fileContents);


                vehiclePaths.ForEach(x =>
                {
                    vehicles.Add(new FileHandler().Process(
                        $"{omsiDirectory}/{x}"
                        ));
                });



                // set full width of items //
                // fill listview with items with vehicles
                vehicles.ForEach(x => {
                    string filename = Path.GetFileName(x.FilePath);
                    ListViewItem item = new ListViewItem() {
                        Text = $"{x.Name.Brand} {x.Name.CarModel} ({filename})",
                        Tag = x
                    };
                    aiListListView.Items.Add(item);
                });

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                omsiDirectory = folderBrowserDialog1.SelectedPath;
                selectAiListFileButton.Enabled = true;
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
        }

        private void writeChangesButton_Click(object sender, EventArgs e)
        {
            foreach(OmsiVehicle vehicle in vehicles)
            {
                if (vehicle.RowdyFactor != null && vehicle.RowdyFactor.Modified)
                {
                    new FileHandler().WriteRowdyFactor(vehicle);
                }
            }
            MessageBox.Show("Done");
        }
    }
}
