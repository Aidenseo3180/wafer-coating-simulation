using System;

namespace WaferLineLib
{
    //Event handler for when 1 wafer is done coating with a delegate
    public delegate void EndCoatingEventHandler(object sender, EndCoatingEventArgs e);

    public class EndCoatingEventArgs:EventArgs
    {
        public int No { get; }  //line #
        public int BWCnt { get; }   //# of wafers before coating
        public int AWCnt { get; }   //# of wafers after coating
        public EndCoatingEventArgs(int no, int bwcnt, int awcnt)
        {
            No = no;
            BWCnt = bwcnt;
            AWCnt = awcnt;
        }
    }
}
