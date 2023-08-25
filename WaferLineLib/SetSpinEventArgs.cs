using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLineLib
{
    //event for spin rate
    public delegate void SetSpinEventHandler(object sender, SetSpinEventArgs e);
    public class SetSpinEventArgs:EventArgs
    {
        public int No { get; }  //line No.
        public int Spin { get; }    //Spin rate of that line No.
        public SetSpinEventArgs(int no, int spin)
        {
            No = no;
            Spin = spin;
        }
    }
}
