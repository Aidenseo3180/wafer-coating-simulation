using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLineLib
{
    //Event handler fpr adding PR(coating liquid) with a delegate

    public delegate void AddPREventHandler(object sender, AddPREventArgs e);
    public class AddPREventArgs:EventArgs
    {
        public int No { get; }  //line # where coating liquid has been added
        public int PCnt { get; }    //# of coating liquid at that line

        public AddPREventArgs(int no, int pcnt)
        {
            No = no;
            PCnt = pcnt;
        }

    }
}
