using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLineLib
{
    //Event Handler for adding wafer with a delegate

    public delegate void AddWaferEventHandler(object sender, AddWaferEventArgs e);

    public class AddWaferEventArgs:EventArgs
    {
        public int No { get; }      //wafer line #
        public int BWCnt { get; }   //# of wafers before coating
        public AddWaferEventArgs(int no, int bwcnt) //constructor
        {
            No = no;
            BWCnt = bwcnt;
        }
    }
}
