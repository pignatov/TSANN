using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plig.TimeSeries.Client
{
    public partial class ChooseProject : Form
    {
        public ChooseProject()
        {
            InitializeComponent();
        }

        private void pROJECTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROJECTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);

        }

        private void ChooseProject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.FREQUENCY' table. You can move, or remove it, as needed.
            this.fREQUENCYTableAdapter.Fill(this.mainDataSet.FREQUENCY);
            // TODO: This line of code loads data into the 'mainDataSet.PROJECT' table. You can move, or remove it, as needed.
            this.pROJECTTableAdapter.Fill(this.mainDataSet.PROJECT);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Program.CurrentProjectID = ((pROJECTBindingSource.Current as DataRowView).Row as MainDataSet.PROJECTRow).ID;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (0 == this.pROJECTBindingSource.Count) return;

            try
            {
                MainDataSet.PROJECTRow row = ((MainDataSet.PROJECTRow)((DataRowView)this.pROJECTBindingSource.Current).Row);
                if (DialogResult.Yes == MessageBox.Show("Сигурни ли сте, че искате да изтриете проект с име: " + row.NAME + " ?", "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    pROJECTBindingSource.RemoveCurrent();
                    try
                    {
                        this.tableAdapterManager.UpdateAll(mainDataSet);
                    }
                    catch { }
                }
            }
            catch
            {      }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChooseProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.mainDataSet.HasChanges())
            {
                this.tableAdapterManager.UpdateAll(mainDataSet);
            }
        }
    }
}
