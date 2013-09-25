using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;

namespace Plig.TimeSeries.Client
{
    public partial class VariableMod : Form
    {
        private string mVariableName;
        private string mNewVariableName;
        private Dictionary<int, double?> mVariableData = new Dictionary<int, double?>();
        private Dictionary<int, double?> mNewVariableData = new Dictionary<int, double?>();

        public string VariableName
        {
            get { return mVariableName; }
            set
            {
                mVariableName = value;
                lblCurrentVariableName.Text = mVariableName;
            }
        }

        public string NewVariableName
        {
            get { return txtNewVariableName.Text; }
            set
            {
                txtNewVariableName.Text = value;
                mNewVariableName = value;
            }
        }

        public Dictionary<int, double?> VariableData
        {
            get { return mVariableData; }
            set { mVariableData = value; }
        }

        public Dictionary<int, double?> NewVariableData
        {
            get { return mNewVariableData; }
            set { mNewVariableData = value; }
        }

        public virtual void Process()
        {
            throw new NotImplementedException();
        }

        public virtual string TransformationDescription()
        {
            throw new NotImplementedException();
        }

        public VariableMod()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Process();
            Vector new_data = new Vector(mNewVariableData.Count);

            if (cbRemoveMean.Checked)
            {
                int cnt = 0;

                foreach (int key in mNewVariableData.Keys)
                {
                    if (mNewVariableData[key].HasValue)
                    {
                        new_data.Values[cnt] = mNewVariableData[key].Value;
                        cnt++;
                    }
                }


                Dictionary<int, double?> data = new Dictionary<int, double?>();

                foreach (int k in mNewVariableData.Keys)
                {
                    if (mNewVariableData[k].HasValue)
                    {
                        data.Add(k, mNewVariableData[k] - new_data.Mean());
                    }
                    else
                    {
                        data.Add(k, null);
                    }
                }

                mNewVariableData = data;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
