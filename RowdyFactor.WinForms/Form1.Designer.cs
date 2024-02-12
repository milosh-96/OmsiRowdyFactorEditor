
namespace RowdyFactor.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            aiListListView = new System.Windows.Forms.ListView();
            Vehicle = new System.Windows.Forms.ColumnHeader();
            editorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            saveVehicleButton = new System.Windows.Forms.Button();
            writeChangesButton = new System.Windows.Forms.Button();
            rowdyNumberEditorGroupBox = new System.Windows.Forms.GroupBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            toRowdyNumberInput = new System.Windows.Forms.NumericUpDown();
            toRowdyNumberLabel = new System.Windows.Forms.Label();
            fromRowdyNumberInput = new System.Windows.Forms.NumericUpDown();
            fromRowdyNumberLabel = new System.Windows.Forms.Label();
            selectAiListFileButton = new System.Windows.Forms.Button();
            currentOmsiDirectoryLabel = new System.Windows.Forms.Label();
            selectChangeOmsiDirButton = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            tableLayoutPanel1.SuspendLayout();
            editorTableLayout.SuspendLayout();
            rowdyNumberEditorGroupBox.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toRowdyNumberInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fromRowdyNumberInput).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            tableLayoutPanel1.Controls.Add(aiListListView, 0, 0);
            tableLayoutPanel1.Controls.Add(editorTableLayout, 1, 0);
            tableLayoutPanel1.Controls.Add(currentOmsiDirectoryLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(selectChangeOmsiDirButton, 0, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(760, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // aiListListView
            // 
            aiListListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Vehicle });
            aiListListView.Dock = System.Windows.Forms.DockStyle.Fill;
            aiListListView.Location = new System.Drawing.Point(3, 3);
            aiListListView.Name = "aiListListView";
            tableLayoutPanel1.SetRowSpan(aiListListView, 2);
            aiListListView.Size = new System.Drawing.Size(279, 534);
            aiListListView.TabIndex = 0;
            aiListListView.UseCompatibleStateImageBehavior = false;
            aiListListView.View = System.Windows.Forms.View.Details;
            aiListListView.ItemSelectionChanged += aiListListView_ItemSelectionChanged;
            // 
            // Vehicle
            // 
            Vehicle.Text = "Vehicle";
            Vehicle.Width = 300;
            // 
            // editorTableLayout
            // 
            editorTableLayout.ColumnCount = 2;
            editorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            editorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            editorTableLayout.Controls.Add(saveVehicleButton, 0, 2);
            editorTableLayout.Controls.Add(writeChangesButton, 0, 0);
            editorTableLayout.Controls.Add(rowdyNumberEditorGroupBox, 1, 1);
            editorTableLayout.Controls.Add(selectAiListFileButton, 1, 0);
            editorTableLayout.Location = new System.Drawing.Point(288, 3);
            editorTableLayout.Name = "editorTableLayout";
            editorTableLayout.RowCount = 3;
            tableLayoutPanel1.SetRowSpan(editorTableLayout, 2);
            editorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            editorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            editorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            editorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            editorTableLayout.Size = new System.Drawing.Size(469, 509);
            editorTableLayout.TabIndex = 2;
            // 
            // saveVehicleButton
            // 
            saveVehicleButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            saveVehicleButton.AutoSize = true;
            saveVehicleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            saveVehicleButton.Location = new System.Drawing.Point(3, 460);
            saveVehicleButton.Name = "saveVehicleButton";
            saveVehicleButton.Size = new System.Drawing.Size(228, 46);
            saveVehicleButton.TabIndex = 4;
            saveVehicleButton.Text = "Save";
            saveVehicleButton.UseVisualStyleBackColor = true;
            saveVehicleButton.Click += saveVehicleButton_Click;
            // 
            // writeChangesButton
            // 
            writeChangesButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            writeChangesButton.AutoSize = true;
            writeChangesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            writeChangesButton.Location = new System.Drawing.Point(3, 3);
            writeChangesButton.Name = "writeChangesButton";
            writeChangesButton.Size = new System.Drawing.Size(228, 44);
            writeChangesButton.TabIndex = 2;
            writeChangesButton.Text = "Write All Changes";
            writeChangesButton.UseVisualStyleBackColor = true;
            writeChangesButton.Click += writeChangesButton_Click;
            // 
            // rowdyNumberEditorGroupBox
            // 
            rowdyNumberEditorGroupBox.Controls.Add(flowLayoutPanel1);
            rowdyNumberEditorGroupBox.Location = new System.Drawing.Point(237, 53);
            rowdyNumberEditorGroupBox.Name = "rowdyNumberEditorGroupBox";
            rowdyNumberEditorGroupBox.Size = new System.Drawing.Size(229, 385);
            rowdyNumberEditorGroupBox.TabIndex = 6;
            rowdyNumberEditorGroupBox.TabStop = false;
            rowdyNumberEditorGroupBox.Text = "Rowdy Number Editor";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(223, 363);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(toRowdyNumberInput, 1, 1);
            tableLayoutPanel2.Controls.Add(toRowdyNumberLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(fromRowdyNumberInput, 1, 0);
            tableLayoutPanel2.Controls.Add(fromRowdyNumberLabel, 0, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // toRowdyNumberInput
            // 
            toRowdyNumberInput.AutoSize = true;
            toRowdyNumberInput.DecimalPlaces = 1;
            toRowdyNumberInput.Dock = System.Windows.Forms.DockStyle.Fill;
            toRowdyNumberInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toRowdyNumberInput.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            toRowdyNumberInput.Location = new System.Drawing.Point(103, 53);
            toRowdyNumberInput.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            toRowdyNumberInput.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            toRowdyNumberInput.Name = "toRowdyNumberInput";
            toRowdyNumberInput.Size = new System.Drawing.Size(94, 29);
            toRowdyNumberInput.TabIndex = 8;
            // 
            // toRowdyNumberLabel
            // 
            toRowdyNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            toRowdyNumberLabel.AutoSize = true;
            toRowdyNumberLabel.BackColor = System.Drawing.Color.Transparent;
            toRowdyNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toRowdyNumberLabel.Location = new System.Drawing.Point(3, 50);
            toRowdyNumberLabel.Name = "toRowdyNumberLabel";
            toRowdyNumberLabel.Size = new System.Drawing.Size(94, 50);
            toRowdyNumberLabel.TabIndex = 9;
            toRowdyNumberLabel.Text = "To:";
            toRowdyNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fromRowdyNumberInput
            // 
            fromRowdyNumberInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            fromRowdyNumberInput.AutoSize = true;
            fromRowdyNumberInput.DecimalPlaces = 1;
            fromRowdyNumberInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fromRowdyNumberInput.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            fromRowdyNumberInput.Location = new System.Drawing.Point(103, 3);
            fromRowdyNumberInput.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            fromRowdyNumberInput.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            fromRowdyNumberInput.Name = "fromRowdyNumberInput";
            fromRowdyNumberInput.Size = new System.Drawing.Size(94, 29);
            fromRowdyNumberInput.TabIndex = 6;
            // 
            // fromRowdyNumberLabel
            // 
            fromRowdyNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            fromRowdyNumberLabel.AutoSize = true;
            fromRowdyNumberLabel.BackColor = System.Drawing.Color.Transparent;
            fromRowdyNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fromRowdyNumberLabel.Location = new System.Drawing.Point(3, 0);
            fromRowdyNumberLabel.Name = "fromRowdyNumberLabel";
            fromRowdyNumberLabel.Size = new System.Drawing.Size(94, 50);
            fromRowdyNumberLabel.TabIndex = 7;
            fromRowdyNumberLabel.Text = "From:";
            fromRowdyNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectAiListFileButton
            // 
            selectAiListFileButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            selectAiListFileButton.AutoSize = true;
            selectAiListFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            selectAiListFileButton.Location = new System.Drawing.Point(237, 3);
            selectAiListFileButton.Name = "selectAiListFileButton";
            selectAiListFileButton.Size = new System.Drawing.Size(229, 44);
            selectAiListFileButton.TabIndex = 1;
            selectAiListFileButton.Text = "Select AI List File";
            selectAiListFileButton.UseVisualStyleBackColor = true;
            selectAiListFileButton.Click += selectAiListFileButton_Click;
            // 
            // currentOmsiDirectoryLabel
            // 
            currentOmsiDirectoryLabel.AutoSize = true;
            currentOmsiDirectoryLabel.Location = new System.Drawing.Point(288, 540);
            currentOmsiDirectoryLabel.Name = "currentOmsiDirectoryLabel";
            currentOmsiDirectoryLabel.Size = new System.Drawing.Size(183, 15);
            currentOmsiDirectoryLabel.TabIndex = 7;
            currentOmsiDirectoryLabel.Text = "OMSI 2 main folder isn't selected!";
            // 
            // selectChangeOmsiDirButton
            // 
            selectChangeOmsiDirButton.AutoSize = true;
            selectChangeOmsiDirButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            selectChangeOmsiDirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            selectChangeOmsiDirButton.Location = new System.Drawing.Point(3, 543);
            selectChangeOmsiDirButton.Name = "selectChangeOmsiDirButton";
            selectChangeOmsiDirButton.Size = new System.Drawing.Size(279, 25);
            selectChangeOmsiDirButton.TabIndex = 7;
            selectChangeOmsiDirButton.Text = "Select/Change Main Folder OMSI ";
            selectChangeOmsiDirButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            selectChangeOmsiDirButton.UseVisualStyleBackColor = true;
            selectChangeOmsiDirButton.Click += selectChangeOmsiDirButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "ailists.cfg";
            openFileDialog1.Filter = "Omsi AiList file|*.cfg";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 591);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Rowdy Factor Editor for OMSI 2";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            editorTableLayout.ResumeLayout(false);
            editorTableLayout.PerformLayout();
            rowdyNumberEditorGroupBox.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)toRowdyNumberInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)fromRowdyNumberInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView aiListListView;
        private System.Windows.Forms.ColumnHeader Vehicle;
        private System.Windows.Forms.TableLayoutPanel editorTableLayout;
        private System.Windows.Forms.Button writeChangesButton;
        private System.Windows.Forms.Button selectAiListFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox rowdyNumberEditorGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label fromRowdyNumberLabel;
        private System.Windows.Forms.NumericUpDown fromRowdyNumberInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown toRowdyNumberInput;
        private System.Windows.Forms.Label toRowdyNumberLabel;
        private System.Windows.Forms.Label currentOmsiDirectoryLabel;
        private System.Windows.Forms.Button selectChangeOmsiDirButton;
        private System.Windows.Forms.Button saveVehicleButton;
    }
}

