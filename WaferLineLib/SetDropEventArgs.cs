using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLineLib
{
    //Event handler for drop rate with a delegate
    public delegate void SetDropEventHandler(object sender, SetDropEventArgs e);
    public class SetDropEventArgs:EventArgs
    {
        public int No { get; }      //line No.
        public int Drop { get; }    //drop rate of that line No.
        public SetDropEventArgs(int no, int drop)
        {
            No = no;
            Drop = drop;
        }
    }
}
