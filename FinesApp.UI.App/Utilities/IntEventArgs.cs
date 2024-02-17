using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinesApp.UI.App.Utilities
{
    public class IntEventArgs : EventArgs
    {
        public int Num { get; set; }

        public IntEventArgs(int num)
        {
            Num = num;
        }
    }

    public delegate void IntEventHandler(object sender, IntEventArgs e);
}
