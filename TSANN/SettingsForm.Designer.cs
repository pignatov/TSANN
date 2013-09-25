namespace Plig.TimeSeries.Client
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            System.Windows.Forms.Label aLCHEMI_SERVER_URLLabel;
            System.Windows.Forms.Label aLCHEMI_PORTLabel;
            System.Windows.Forms.Label aLCHEMI_USERNAMELabel;
            System.Windows.Forms.Label aLCHEMI_PASSWORDLabel;
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tabAlchemi = new System.Windows.Forms.TabPage();
            this.mainDataSet = new Plig.TimeSeries.Client.MainDataSet();
            this.sETTINGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sETTINGSTableAdapter = new Plig.TimeSeries.Client.MainDataSetTableAdapters.SETTINGSTableAdapter();
            this.tableAdapterManager = new Plig.TimeSeries.Client.MainDataSetTableAdapters.TableAdapterManager();
            this.aLCHEMI_SERVER_URLTextBox = new System.Windows.Forms.TextBox();
            this.aLCHEMI_PORTTextBox = new System.Windows.Forms.TextBox();
            this.aLCHEMI_USERNAMETextBox = new System.Windows.Forms.TextBox();
            this.aLCHEMI_PASSWORDTextBox = new System.Windows.Forms.TextBox();
            aLCHEMI_SERVER_URLLabel = new System.Windows.Forms.Label();
            aLCHEMI_PORTLabel = new System.Windows.Forms.Label();
            aLCHEMI_USERNAMELabel = new System.Windows.Forms.Label();
            aLCHEMI_PASSWORDLabel = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.tabAlchemi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETTINGSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(139, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(244, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 254);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(467, 49);
            this.pnlButtons.TabIndex = 2;
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tabAlchemi);
            this.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSettings.Location = new System.Drawing.Point(0, 0);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(467, 254);
            this.tcSettings.TabIndex = 3;
            // 
            // tabAlchemi
            // 
            this.tabAlchemi.Controls.Add(aLCHEMI_SERVER_URLLabel);
            this.tabAlchemi.Controls.Add(this.aLCHEMI_SERVER_URLTextBox);
            this.tabAlchemi.Controls.Add(aLCHEMI_PORTLabel);
            this.tabAlchemi.Controls.Add(this.aLCHEMI_PORTTextBox);
            this.tabAlchemi.Controls.Add(aLCHEMI_USERNAMELabel);
            this.tabAlchemi.Controls.Add(this.aLCHEMI_USERNAMETextBox);
            this.tabAlchemi.Controls.Add(aLCHEMI_PASSWORDLabel);
            this.tabAlchemi.Controls.Add(this.aLCHEMI_PASSWORDTextBox);
            this.tabAlchemi.Location = new System.Drawing.Point(4, 22);
            this.tabAlchemi.Name = "tabAlchemi";
            this.tabAlchemi.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlchemi.Size = new System.Drawing.Size(459, 228);
            this.tabAlchemi.TabIndex = 0;
            this.tabAlchemi.Text = "Alchemi";
            this.tabAlchemi.UseVisualStyleBackColor = true;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sETTINGSBindingSource
            // 
            this.sETTINGSBindingSource.DataMember = "SETTINGS";
            this.sETTINGSBindingSource.DataSource = this.mainDataSet;
            // 
            // sETTINGSTableAdapter
            // 
            this.sETTINGSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FREQUENCYTableAdapter = null;
            this.tableAdapterManager.OBSERVATIONSTableAdapter = null;
            this.tableAdapterManager.PROJECTTableAdapter = null;
            this.tableAdapterManager.SETTINGSTableAdapter = this.sETTINGSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Plig.TimeSeries.Client.MainDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VARIABLESTableAdapter = null;
            // 
            // aLCHEMI_SERVER_URLLabel
            // 
            aLCHEMI_SERVER_URLLabel.AutoSize = true;
            aLCHEMI_SERVER_URLLabel.Location = new System.Drawing.Point(105, 42);
            aLCHEMI_SERVER_URLLabel.Name = "aLCHEMI_SERVER_URLLabel";
            aLCHEMI_SERVER_URLLabel.Size = new System.Drawing.Size(81, 13);
            aLCHEMI_SERVER_URLLabel.TabIndex = 0;
            aLCHEMI_SERVER_URLLabel.Text = "Alchemi Server:";
            // 
            // aLCHEMI_SERVER_URLTextBox
            // 
            this.aLCHEMI_SERVER_URLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sETTINGSBindingSource, "ALCHEMI_SERVER_URL", true));
            this.aLCHEMI_SERVER_URLTextBox.Location = new System.Drawing.Point(240, 39);
            this.aLCHEMI_SERVER_URLTextBox.Name = "aLCHEMI_SERVER_URLTextBox";
            this.aLCHEMI_SERVER_URLTextBox.Size = new System.Drawing.Size(196, 20);
            this.aLCHEMI_SERVER_URLTextBox.TabIndex = 1;
            // 
            // aLCHEMI_PORTLabel
            // 
            aLCHEMI_PORTLabel.AutoSize = true;
            aLCHEMI_PORTLabel.Location = new System.Drawing.Point(105, 69);
            aLCHEMI_PORTLabel.Name = "aLCHEMI_PORTLabel";
            aLCHEMI_PORTLabel.Size = new System.Drawing.Size(29, 13);
            aLCHEMI_PORTLabel.TabIndex = 4;
            aLCHEMI_PORTLabel.Text = "Port:";
            // 
            // aLCHEMI_PORTTextBox
            // 
            this.aLCHEMI_PORTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sETTINGSBindingSource, "ALCHEMI_PORT", true));
            this.aLCHEMI_PORTTextBox.Location = new System.Drawing.Point(240, 66);
            this.aLCHEMI_PORTTextBox.Name = "aLCHEMI_PORTTextBox";
            this.aLCHEMI_PORTTextBox.Size = new System.Drawing.Size(45, 20);
            this.aLCHEMI_PORTTextBox.TabIndex = 5;
            // 
            // aLCHEMI_USERNAMELabel
            // 
            aLCHEMI_USERNAMELabel.AutoSize = true;
            aLCHEMI_USERNAMELabel.Location = new System.Drawing.Point(105, 95);
            aLCHEMI_USERNAMELabel.Name = "aLCHEMI_USERNAMELabel";
            aLCHEMI_USERNAMELabel.Size = new System.Drawing.Size(58, 13);
            aLCHEMI_USERNAMELabel.TabIndex = 6;
            aLCHEMI_USERNAMELabel.Text = "Username:";
            // 
            // aLCHEMI_USERNAMETextBox
            // 
            this.aLCHEMI_USERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sETTINGSBindingSource, "ALCHEMI_USERNAME", true));
            this.aLCHEMI_USERNAMETextBox.Location = new System.Drawing.Point(240, 92);
            this.aLCHEMI_USERNAMETextBox.Name = "aLCHEMI_USERNAMETextBox";
            this.aLCHEMI_USERNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.aLCHEMI_USERNAMETextBox.TabIndex = 7;
            // 
            // aLCHEMI_PASSWORDLabel
            // 
            aLCHEMI_PASSWORDLabel.AutoSize = true;
            aLCHEMI_PASSWORDLabel.Location = new System.Drawing.Point(105, 121);
            aLCHEMI_PASSWORDLabel.Name = "aLCHEMI_PASSWORDLabel";
            aLCHEMI_PASSWORDLabel.Size = new System.Drawing.Size(56, 13);
            aLCHEMI_PASSWORDLabel.TabIndex = 8;
            aLCHEMI_PASSWORDLabel.Text = "Password:";
            // 
            // aLCHEMI_PASSWORDTextBox
            // 
            this.aLCHEMI_PASSWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sETTINGSBindingSource, "ALCHEMI_PASSWORD", true));
            this.aLCHEMI_PASSWORDTextBox.Location = new System.Drawing.Point(240, 118);
            this.aLCHEMI_PASSWORDTextBox.Name = "aLCHEMI_PASSWORDTextBox";
            this.aLCHEMI_PASSWORDTextBox.Size = new System.Drawing.Size(100, 20);
            this.aLCHEMI_PASSWORDTextBox.TabIndex = 9;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(467, 303);
            this.Controls.Add(this.tcSettings);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.pnlButtons.ResumeLayout(false);
            this.tcSettings.ResumeLayout(false);
            this.tabAlchemi.ResumeLayout(false);
            this.tabAlchemi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETTINGSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tabAlchemi;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource sETTINGSBindingSource;
        private Plig.TimeSeries.Client.MainDataSetTableAdapters.SETTINGSTableAdapter sETTINGSTableAdapter;
        private Plig.TimeSeries.Client.MainDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox aLCHEMI_SERVER_URLTextBox;
        private System.Windows.Forms.TextBox aLCHEMI_PORTTextBox;
        private System.Windows.Forms.TextBox aLCHEMI_USERNAMETextBox;
        private System.Windows.Forms.TextBox aLCHEMI_PASSWORDTextBox;
    }
}