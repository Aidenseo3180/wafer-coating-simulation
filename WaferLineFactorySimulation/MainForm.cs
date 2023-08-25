using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaferLineLib;

namespace WaferLineFactorySimulation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int next_line_no = 1;
        //to prevent re-creating already defined wafer line, store the line no and wafer line in dictonary
        Dictionary<int, WaferLineForm> wdic = new Dictionary<int, WaferLineForm>();

        private void btn_add_Click(object sender, EventArgs e)
        {
            int no = next_line_no;
            next_line_no++;
            WaferLine wl = new WaferLine(no);

            //have to add to listView of MainForm
            string[] sitems = new string[] { no.ToString(), "0", "0" };
            ListViewItem lvi = new ListViewItem(sitems);
            //winForm has Tag that allows 1:1 mapping to control with object (it can store object)
            lvi.Tag = wl;
            lv_line.Items.Add(lvi); //add to ListView to display
            cb_line.Items.Add(wl);  //also add to combo box to display added wafers
            lb_next_no.Text = next_line_no.ToString();  //change text

            WaferLineForm wlf = new WaferLineForm(wl);
            //Add Event handlers
            wlf.EndedCoating += Wlf_EndedCoating;
            wlf.EndedPR += Wlf_EndedPR;
            wlf.AddedWafer += Wlf_AddedWafer;
            wlf.AddedPR += Wlf_AddedPR;
            wlf.SetSpinRate += Wlf_SetSpinRate;
            wlf.SetDropRate += Wlf_SetDropRate;
            wdic.Add(no, wlf);
        }

        //gets called when drop rate gets changed
        private void Wlf_SetDropRate(object sender, SetDropEventArgs e)
        {
            ChangeStatusSelectedWaferLine(e.No);
        }

        private void ChangeStatusSelectedWaferLine(int no)
        {
            ListViewItem lvi = lv_line.Items[no - 1];
            if (lvi.Selected)
            {
                WaferLine wl = lvi.Tag as WaferLine;
                lb_spin.Text = wl.Spin.ToString();
                lb_drop.Text = wl.Drop.ToString();
                lb_pr.Text = wl.PCnt.ToString();
            }
        }
        private void Wlf_SetSpinRate(object sender, SetSpinEventArgs e)
        {
            ChangeStatusSelectedWaferLine(e.No);
        }

        private void Wlf_EndedPR(object sender, EndPREventArgs e)
        {
            //First, we access the ListView item corresponding to e
            ListViewItem lvi = lv_line.Items[e.No - 1];
            //if lvi has been selected by user
            if (lvi.Selected)
            {
                WaferLine wl = lvi.Tag as WaferLine;    //bring the WaferLine object that we tagged with ListViewItem
                lb_pr.Text = wl.PCnt.ToString();
            }
        }

        private void Wlf_AddedPR(object sender, AddPREventArgs e)
        {
            ChangeStatusSelectedWaferLine(e.No);
        }

        //since columns of ListView should change even if it's not selected
        private void Wlf_AddedWafer(object sender, AddWaferEventArgs e)
        {
            ChangeStatusWaferLine(e.No);
        }

        private void ChangeStatusWaferLine(int no)
        {
            ListViewItem lvi = lv_line.Items[no - 1];
            WaferLine wl = lvi.Tag as WaferLine;
            lvi.SubItems[1].Text = wl.BWCnt.ToString(); //1st column has before coating
            lvi.SubItems[2].Text = wl.AWCnt.ToString(); //2nd column has after coating
            cb_line.Items[no - 1] = wl; //add waferline to combobox
        }

        private void Wlf_EndedCoating(object sender, EndCoatingEventArgs e)
        {
            ChangeStatusWaferLine(e.No);
            //Since there's a coating liquid amount displaying on right side
            ListViewItem lvi = lv_line.Items[e.No - 1];
            if (lvi.Selected)
            {
                WaferLine wl = lvi.Tag as WaferLine;
                cb_awafer.Items.Add(wl.LastWafer);  //add most recently coated wafer to after wafer combobox
                lb_pr.Text = wl.PCnt.ToString();
            }
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            if (cb_line.SelectedIndex == -1)
            {
                return;
            }
            WaferLine wl = cb_line.SelectedItem as WaferLine;
            //if the waferline that we selected through combo box is not visible
            //meaning it already exists but not getting displayed
            if (wdic[wl.No].Visible == false)
            {
                wdic[wl.No].Show();
            }
        }

        private void cb_awafer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the selected coated wafer and give it to panel
            pn_awafer.Wafer = cb_awafer.SelectedItem as Wafer;
            //redraw
            pn_awafer.Invalidate();
        }
    }
}
