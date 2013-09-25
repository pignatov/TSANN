using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plig.TimeSeries.Client
{
    public partial class VariableLag : Plig.TimeSeries.Client.VariableMod
    {
        public VariableLag()
        {
            InitializeComponent();
        }

        public override void Process()
        {
            int? old_key = null;
            int cnt = 0;

            ObsRec[] observations = new ObsRec[VariableData.Keys.Count];

            foreach (int key in VariableData.Keys)
            {
                ObsRec obs = new ObsRec();
                obs.Key = key;
                obs.Value = VariableData[key];
                observations[cnt] = obs;
                cnt++;
            }

            for (int i = 0; i < udDiff.Value; i++)
            {
                NewVariableData.Add((observations[i] as ObsRec).Key, null);
            }

            for (int i = (int)udDiff.Value; i < observations.Length; i++)
            {
                NewVariableData.Add((observations[i] as ObsRec).Key,
                    (observations[i - (int)udDiff.Value] as ObsRec).Value);
            }
        }

        private void udDiff_ValueChanged(object sender, EventArgs e)
        {
            NewVariableName = "L" + udDiff.Value.ToString() + "_" + VariableName;
        }

        private void VariableLag_Load(object sender, EventArgs e)
        {
            NewVariableName = "L" + udDiff.Value.ToString() + "_" + VariableName;
        }

        public override string TransformationDescription()
        {
            string modifier = string.Empty;
            int diff = (int)(udDiff.Value % 10);
            switch (diff)
            {
                case 1: modifier = "ви"; break;
                case 2: modifier = "ри"; break;
                default:
                    if (udDiff.Value == 11) modifier = "ти";
                    else
                        if (udDiff.Value == 12) modifier = "ви";
                        else
                            modifier = "ти"; break;
            }

            return String.Format("Лаг от {0}-{1} ред ", udDiff.Value.ToString(), modifier);
        }


    }
}
