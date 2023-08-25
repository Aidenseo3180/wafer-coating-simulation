using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLineLib
{
    //Event handler for when run out of coating liquid and has to grab a new bottle of coating liquid with a delegate
    public delegate void EndPREventHandler(object sender, EndPREventArgs e);
    public class EndPREventArgs:EventArgs
    {
        public int No { get; }
        public EndPREventArgs(int no)   //if we know the line #, we can grab its property that has # of coating liquid bottles
        {
            No = no;
        }
    }
}
