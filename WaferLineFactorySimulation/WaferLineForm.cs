using System;
using System.Windows.Forms;
using WaferLineLib;

namespace WaferLineFactorySimulation
{
    public partial class WaferLineForm : Form
    {
        //Receive events
        public event AddWaferEventHandler AddedWafer;
        public event AddPREventHandler AddedPR;
        public event SetSpinEventHandler SetSpinRate;
        public event SetDropEventHandler SetDropRate;
        public event EndPREventHandler EndedPR;
        public event EndCoatingEventHandler EndedCoating;

        public WaferLine WLine { get; }
        public int No { get { return WLine.No; } }
        public WaferLineForm(WaferLine wl)
        {
            InitializeComponent();
            WLine = wl;
            WLine.AddedWafer += WLine_AddedWafer;
            WLine.AddedPR += WLine_AddedPR;
            WLine.EndedCoating += WLine_EndedCoating;
            WLine.EndedPR += WLine_EndedPR;
            WLine.SetSpinRate += WLine_SetSpinRate;
            WLine.SetDropRate += WLine_SetDropRate;
        }

        //These methods will be used to pass events to MainForm
        private void WLine_SetDropRate(object sender, SetDropEventArgs e)
        {
            //check if event exists
            if (SetDropRate != null)
            {
                SetDropRate(this, e);
            }
        }

        private void WLine_SetSpinRate(object sender, SetSpinEventArgs e)
        {
            if (SetSpinRate != null)
            {
                SetSpinRate(this, e);
            }
        }

        private void WLine_EndedPR(object sender, EndPREventArgs e)
        {
            if (EndedPR != null)
            {
                EndedPR(this, e);
            }
        }

        private void WLine_EndedCoating(object sender, EndCoatingEventArgs e)
        {
            if (EndedCoating != null)
            {
                EndedCoating(this, e);
            }
        }

        private void WLine_AddedPR(object sender, AddPREventArgs e)
        {
            if (AddedPR != null)
            {
                AddedPR(this, e);
            }
        }

        private void WLine_AddedWafer(object sender, AddWaferEventArgs e)
        {
            if (AddedWafer != null)
            {
                AddedWafer(this, e);
            }
        }

        private void WaferLineForm_Load(object sender, EventArgs e)
        {
            lb_no.Text = No.ToString();
            wlc.Line = WLine;
        }

        //When WaferLine form is closing, hide instead of close
        private void WaferLineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();        //hide the window
            e.Cancel = true;    //mark it as true to pretend that the window has been fully closed to prevent system from freeing resources 
        }
    }
}
