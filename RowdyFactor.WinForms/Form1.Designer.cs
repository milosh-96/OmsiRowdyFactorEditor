
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.aiListListView = new System.Windows.Forms.ListView();
            this.Vehicle = new System.Windows.Forms.ColumnHeader();
            this.editorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.saveVehicleButton = new System.Windows.Forms.Button();
            this.writeChangesButton = new System.Windows.Forms.Button();
            this.rowdyNumberEditorGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toRowdyNumberInput = new System.Windows.Forms.NumericUpDown();
            this.toRowdyNumberLabel = new System.Windows.Forms.Label();
            this.fromRowdyNumberInput = new System.Windows.Forms.NumericUpDown();
            this.fromRowdyNumberLabel = new System.Windows.Forms.Label();
            this.selectAiListFileButton = new System.Windows.Forms.Button();
            this.currentOmsiDirectoryLabel = new System.Windows.Forms.Label();
            this.selectChangeOmsiDirButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.editorTableLayout.SuspendLayout();
            this.rowdyNumberEditorGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toRowdyNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromRowdyNumberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.aiListListView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editorTableLayout, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentOmsiDirectoryLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.selectChangeOmsiDirButton, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // aiListListView
            // 
            this.aiListListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Vehicle});
            this.aiListListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aiListListView.Location = new System.Drawing.Point(3, 3);
            this.aiListListView.Name = "aiListListView";
            this.tableLayoutPanel1.SetRowSpan(this.aiListListView, 2);
            this.aiListListView.Size = new System.Drawing.Size(279, 534);
            this.aiListListView.TabIndex = 0;
            this.aiListListView.UseCompatibleStateImageBehavior = false;
            this.aiListListView.View = System.Windows.Forms.View.Details;
            this.aiListListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.aiListListView_ItemSelectionChanged);
            // 
            // Vehicle
            // 
            this.Vehicle.Text = "Vehicle";
            this.Vehicle.Width = 300;
            // 
            // editorTableLayout
            // 
            this.editorTableLayout.ColumnCount = 2;
            this.editorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.editorTableLayout.Controls.Add(this.saveVehicleButton, 0, 2);
            this.editorTableLayout.Controls.Add(this.writeChangesButton, 0, 0);
            this.editorTableLayout.Controls.Add(this.rowdyNumberEditorGroupBox, 1, 1);
            this.editorTableLayout.Controls.Add(this.selectAiListFileButton, 1, 0);
            this.editorTableLayout.Location = new System.Drawing.Point(288, 3);
            this.editorTableLayout.Name = "editorTableLayout";
            this.editorTableLayout.RowCount = 3;
            this.tableLayoutPanel1.SetRowSpan(this.editorTableLayout, 2);
            this.editorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.editorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editorTableLayout.Size = new System.Drawing.Size(469, 509);
            this.editorTableLayout.TabIndex = 2;
            // 
            // saveVehicleButton
            // 
            this.saveVehicleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveVehicleButton.AutoSize = true;
            this.saveVehicleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveVehicleButton.Location = new System.Drawing.Point(3, 460);
            this.saveVehicleButton.Name = "saveVehicleButton";
            this.saveVehicleButton.Size = new System.Drawing.Size(228, 46);
            this.saveVehicleButton.TabIndex = 4;
            this.saveVehicleButton.Text = "Save";
            this.saveVehicleButton.UseVisualStyleBackColor = true;
            this.saveVehicleButton.Click += new System.EventHandler(this.saveVehicleButton_Click);
            // 
            // writeChangesButton
            // 
            this.writeChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writeChangesButton.AutoSize = true;
            this.writeChangesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.writeChangesButton.Location = new System.Drawing.Point(3, 3);
            this.writeChangesButton.Name = "writeChangesButton";
            this.writeChangesButton.Size = new System.Drawing.Size(228, 44);
            this.writeChangesButton.TabIndex = 2;
            this.writeChangesButton.Text = "Write All Changes";
            this.writeChangesButton.UseVisualStyleBackColor = true;
            this.writeChangesButton.Click += new System.EventHandler(this.writeChangesButton_Click);
            // 
            // rowdyNumberEditorGroupBox
            // 
            this.rowdyNumberEditorGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.rowdyNumberEditorGroupBox.Location = new System.Drawing.Point(237, 53);
            this.rowdyNumberEditorGroupBox.Name = "rowdyNumberEditorGroupBox";
            this.rowdyNumberEditorGroupBox.Size = new System.Drawing.Size(229, 385);
            this.rowdyNumberEditorGroupBox.TabIndex = 6;
            this.rowdyNumberEditorGroupBox.TabStop = false;
            this.rowdyNumberEditorGroupBox.Text = "Rowdy Number Editor";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 363);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.toRowdyNumberInput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.toRowdyNumberLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.fromRowdyNumberInput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.fromRowdyNumberLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // toRowdyNumberInput
            // 
            this.toRowdyNumberInput.AutoSize = true;
            this.toRowdyNumberInput.DecimalPlaces = 1;
            this.toRowdyNumberInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toRowdyNumberInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toRowdyNumberInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.toRowdyNumberInput.Location = new System.Drawing.Point(103, 53);
            this.toRowdyNumberInput.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.toRowdyNumberInput.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.toRowdyNumberInput.Name = "toRowdyNumberInput";
            this.toRowdyNumberInput.Size = new System.Drawing.Size(94, 29);
            this.toRowdyNumberInput.TabIndex = 8;
            // 
            // toRowdyNumberLabel
            // 
            this.toRowdyNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toRowdyNumberLabel.AutoSize = true;
            this.toRowdyNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.toRowdyNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toRowdyNumberLabel.Location = new System.Drawing.Point(3, 50);
            this.toRowdyNumberLabel.Name = "toRowdyNumberLabel";
            this.toRowdyNumberLabel.Size = new System.Drawing.Size(94, 50);
            this.toRowdyNumberLabel.TabIndex = 9;
            this.toRowdyNumberLabel.Text = "To:";
            this.toRowdyNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fromRowdyNumberInput
            // 
            this.fromRowdyNumberInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromRowdyNumberInput.AutoSize = true;
            this.fromRowdyNumberInput.DecimalPlaces = 1;
            this.fromRowdyNumberInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromRowdyNumberInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fromRowdyNumberInput.Location = new System.Drawing.Point(103, 3);
            this.fromRowdyNumberInput.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.fromRowdyNumberInput.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.fromRowdyNumberInput.Name = "fromRowdyNumberInput";
            this.fromRowdyNumberInput.Size = new System.Drawing.Size(94, 29);
            this.fromRowdyNumberInput.TabIndex = 6;
            // 
            // fromRowdyNumberLabel
            // 
            this.fromRowdyNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromRowdyNumberLabel.AutoSize = true;
            this.fromRowdyNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.fromRowdyNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromRowdyNumberLabel.Location = new System.Drawing.Point(3, 0);
            this.fromRowdyNumberLabel.Name = "fromRowdyNumberLabel";
            this.fromRowdyNumberLabel.Size = new System.Drawing.Size(94, 50);
            this.fromRowdyNumberLabel.TabIndex = 7;
            this.fromRowdyNumberLabel.Text = "From:";
            this.fromRowdyNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectAiListFileButton
            // 
            this.selectAiListFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAiListFileButton.AutoSize = true;
            this.selectAiListFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectAiListFileButton.Location = new System.Drawing.Point(237, 3);
            this.selectAiListFileButton.Name = "selectAiListFileButton";
            this.selectAiListFileButton.Size = new System.Drawing.Size(229, 44);
            this.selectAiListFileButton.TabIndex = 1;
            this.selectAiListFileButton.Text = "Select AI List File";
            this.selectAiListFileButton.UseVisualStyleBackColor = true;
            this.selectAiListFileButton.Click += new System.EventHandler(this.selectAiListFileButton_Click);
            // 
            // currentOmsiDirectoryLabel
            // 
            this.currentOmsiDirectoryLabel.AutoSize = true;
            this.currentOmsiDirectoryLabel.Location = new System.Drawing.Point(288, 540);
            this.currentOmsiDirectoryLabel.Name = "currentOmsiDirectoryLabel";
            this.currentOmsiDirectoryLabel.Size = new System.Drawing.Size(183, 15);
            this.currentOmsiDirectoryLabel.TabIndex = 7;
            this.currentOmsiDirectoryLabel.Text = "OMSI 2 main folder isn\'t selected!";
            // 
            // selectChangeOmsiDirButton
            // 
            this.selectChangeOmsiDirButton.AutoSize = true;
            this.selectChangeOmsiDirButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectChangeOmsiDirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectChangeOmsiDirButton.Location = new System.Drawing.Point(3, 543);
            this.selectChangeOmsiDirButton.Name = "selectChangeOmsiDirButton";
            this.selectChangeOmsiDirButton.Size = new System.Drawing.Size(279, 25);
            this.selectChangeOmsiDirButton.TabIndex = 7;
            this.selectChangeOmsiDirButton.Text = "Select/Change Main Folder OMSI ";
            this.selectChangeOmsiDirButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectChangeOmsiDirButton.UseVisualStyleBackColor = true;
            this.selectChangeOmsiDirButton.Click += new System.EventHandler(this.selectChangeOmsiDirButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ailists.cfg";
            this.openFileDialog1.Filter = "Omsi AiList file|*.cfg";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rowdy Factor Editor for OMSI 2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.editorTableLayout.ResumeLayout(false);
            this.editorTableLayout.PerformLayout();
            this.rowdyNumberEditorGroupBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toRowdyNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromRowdyNumberInput)).EndInit();
            this.ResumeLayout(false);

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

