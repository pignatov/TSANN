using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plig.TimeSeries.Client
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void sETTINGSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sETTINGSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.SETTINGS' table. You can move, or remove it, as needed.
            this.sETTINGSTableAdapter.Fill(this.mainDataSet.SETTINGS);
            if (this.mainDataSet.SETTINGS.Count == 0)
            {
                // Няма елемент в таблицата settings - трябва да създадем
                MainDataSet.SETTINGSRow settings = this.mainDataSet.SETTINGS.NewSETTINGSRow();
                settings.ALCHEMI_SERVER_URL = "localhost";
                settings.ALCHEMI_PORT = 9000;
                settings.ALCHEMI_USERNAME = "user";
                settings.ALCHEMI_PASSWORD = "user";
                this.mainDataSet.SETTINGS.AddSETTINGSRow(settings);
                sETTINGSBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mainDataSet);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sETTINGSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
