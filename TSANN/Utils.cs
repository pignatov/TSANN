using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dew.Math;

namespace Plig.TimeSeries.Client
{
    class Utils
    {
        public static double DurbinWatson(Vector residuals)
        {
            double above = 0.0;
            for (int i = 1; i < residuals.Length; i++)
            {
                above += (residuals.Values[i] - residuals.Values[i - 1]) * (residuals.Values[i] - residuals.Values[i - 1]);
            }

            double below = 0.0;
            for (int i = 0; i < residuals.Length; i++)
            {
                below += residuals.Values[i] * residuals.Values[i];
            }

            return above/below;
        }

        private delegate void SetTextCallback(System.Windows.Forms.Control control, string text);

        // Thread safe updating of control's text property
        public static void SetText(System.Windows.Forms.Control control, string text)
        {
            if (control.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                control.Parent.Invoke(d, new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }

    }
}
