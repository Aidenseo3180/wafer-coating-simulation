using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WaferLineLib;

namespace WaferLineControlLib
{
    public partial class WaferLineControl: UserControl
    {
        WaferLine wl = null;

        public WaferLine Line
        {
            get
            {
                return wl;
            }
            set
            {
                wl = value;
            }
        }

        public WaferLineControl()
        {
            InitializeComponent();
        }

        private void tbar_wafer_Scroll(object sender, EventArgs e)
        {
            //if there's no wafer
            if (wl == null) { return; }

            lb_wafer.Text = tbar_wafer.Value.ToString();
        }

        private void tbar_pr_Scroll(object sender, EventArgs e)
        {
            if (wl == null) { return; }

            lb_pr.Text = tbar_pr.Value.ToString();
        }

        private void btn_wafer_Click(object sender, EventArgs e)
        {
            if (wl == null) { return; }

            //add beforeWaferCnt
            int bwcnt = tbar_wafer.Value;
            //if will-be added wafers are more than max - non-coated wafers
            if (bwcnt > (tbar_wafer.Maximum - wl.BWCnt))
            {
                bwcnt = tbar_wafer.Maximum - wl.BWCnt;
            }

            wl.InWafer(bwcnt);

            tbar_wafer.Value = 0;
            lb_wafer.Text = "0";
            //redraw non-coated wafers panel display
            pn_wafer.Invalidate();
            //updatestatus bar
            ts_lb.Text = string.Format("Wafer {0} inserted, Currently: {1}", bwcnt, wl.BWCnt);
            //update the display of BWCnt
            lb_wcnt.Text = wl.BWCnt.ToString();
        }

        private void btn_pr_Click(object sender, EventArgs e)
        {
            if (wl == null) { return; }

            int pcnt = tbar_pr.Value;
            if (pcnt > (tbar_pr.Maximum - wl.PCnt))
            {
                pcnt = tbar_pr.Maximum - wl.PCnt;
            }

            wl.InPr(pcnt);
            tbar_pr.Value = 0;
            lb_pr.Text = "0";
            pn_pr.Invalidate();
            ts_lb.Text = string.Format("Coating liquid {0} inserted, Currently: {1}", pcnt, wl.PCnt);
            lb_pcnt.Text = wl.PCnt.ToString();
        }

        private void tbar_spin_Scroll(object sender, EventArgs e)
        {
            if (wl == null) { return; }

            lb_spin.Text = tbar_spin.Value.ToString();
            wl.SetSpin(tbar_spin.Value);
            ChangeInterval();
        }

        //when spin/drop rate changes, the speed of coating changes
        private void ChangeInterval()
        {
            if (wl == null) { return; }
            tm_coating.Interval = 6000000 / (wl.Spin * wl.Drop);
        }

        private void tbar_drop_Scroll(object sender, EventArgs e)
        {
            if (wl == null) { return; }

            lb_drop.Text = tbar_drop.Value.ToString();
            wl.SetDrop(tbar_drop.Value);
            ChangeInterval();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (wl == null) { return; }

            //if coating timer is enabled
            if (tm_coating.Enabled == true)
            {
                tm_coating.Enabled = false;
                btn_start.Text = "Start";
            }
            else
            {
                tm_coating.Enabled = true;
                btn_start.Text = "Paused";
            }
        }

        private void cb_awafer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if nothing is chosen
            if (cb_awafer.SelectedIndex == -1)
            {
                return;
            }

            //get selected wafer at that index, convert it to Wafer class
            Wafer wafer = cb_awafer.SelectedItem as Wafer;
            pn_awafer.Wafer = wafer;
            pn_awafer.Invalidate(); //invalidate it to visualize it (redraw the new Wafer that has been selected)
        }

        private void tm_coating_Tick(object sender, EventArgs e)
        {
            if (wl == null) { return; }

            //coat until returns false. When it's false, it means there's either no wafer or no coating liquid
            if (wl.Coating() == false)
            {
                tm_coating.Enabled = false;
                btn_start.Text = "Start";
            }

            Wafer wafer = wl.Now;
            pn_nwafer.Wafer = wafer;
            //if there's a wafer we can work on
            if (wafer != null)
            {
                int ccount = wafer.Now;
                if (ccount == 1)    //if current wafer is done
                {
                    Wafer lwafer = wl.LastWafer;
                    if (lwafer != null)
                    {
                        //add to coated wafer list
                        cb_awafer.Items.Add(lwafer);
                        //display new # of total coated wafers
                        lb_awcnt.Text = wl.AWCnt.ToString();
                        ts_lb.Text = string.Format("Coating has finished: {0}", lwafer);
                    }

                    lb_wcnt.Text = wl.BWCnt.ToString();
                }
            }

            //if # of cells that we can coat is 999, that means new coating liquid bottle has been used
            if (wl.NPCnt == 999)
            {
                //update display of the # of bottles left
                lb_pcnt.Text = wl.PCnt.ToString();
                ts_lb.Text = string.Format("Coating liquid bottle changed. Remaining: {0}", wl.PCnt);
            }

            //give true to redraw itself
            Invalidate(true);
        }

        private void pn_wafer_Paint(object sender, PaintEventArgs e)
        {
            if (wl == null) { return; }

            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.DarkGray, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; //dotted line style
            int xu = pn_wafer.Width / 10;
            int yu = pn_wafer.Height / 20;
            int wcnt = wl.BWCnt;
            //Since we want 10 x 20 dimension painting
            //draw 9 lines (since we want 10 cells per row and borders already exist, 9 lines are enough)
            for (int x = 1; x < 10; x++)
            {
                graphics.DrawLine(pen, new Point(x * xu, 0), new Point(x * xu, pn_wafer.Height));
            }
            for (int y = 1; y < 20; y++)
            {
                graphics.DrawLine(pen, new Point(0, y * yu), new Point(pn_wafer.Width, y * yu));
            }

            //when it paints, we want to start from bottom to top
            for (int i = 0, ri = 200; i < 200; i++, ri--)
            {
                Brush brush;
                //wcnt is where wafers do exist. If ri <= wcnt, that means we know that at that spot, we have wafer
                if (ri <= wcnt)
                {
                    //use hatchbrush to make it look better
                    brush = new HatchBrush(HatchStyle.DiagonalCross, Color.Goldenrod);
                }
                //if there's no wafers, use different style to indiciate
                else
                {
                    brush = new SolidBrush(pn_wafer.BackColor);
                }
                int x = i % 10;
                int y = i / 10;
                graphics.FillRectangle(brush, new Rectangle(x * xu + 1, y * yu + 1, xu - 1, yu - 1)); //+1, -1 for lines (pen take up 1 space)
            }
        }

        private void pn_pr_Paint(object sender, PaintEventArgs e)
        {
            if (wl == null) { return; }
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.DarkGray, 1);
            pen.DashStyle = DashStyle.Dot;

            //Since there are only 20 bottles, only draw 19 lines horizontally to display 20 floors, each for a bottle
            int yu = pn_pr.Height / 20;
            for (int y = 1; y < 20; y++)
            {
                graphics.DrawLine(pen, new Point(0, y * yu), new Point(pn_pr.Width, y * yu));
            }
            int pcnt = wl.PCnt;
            for (int i = 0, ri = 20; i < 20; i++, ri--)
            {
                Color color = pn_pr.BackColor;
                //if ri <= # of bottles
                if (ri <= pcnt)
                {
                    color = Color.DarkCyan;
                }
                Brush brush = new SolidBrush(color);
                graphics.FillRectangle(brush, new Rectangle(0, i * yu + 1, pn_pr.Width, yu - 1));
            }
        }

        private void pn_npr_Paint(object sender, PaintEventArgs e)
        {
            if (wl == null) { return; }

            Graphics graphics = e.Graphics;
            //# of cells we can current coat (the amount of liquid, max 1000 cells can be coated)
            int npcnt = wl.NPCnt;
            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    //if we do have some amount to coat the cell
                    if (npcnt < (1000 - y * 50 + x))
                    {
                        graphics.DrawLine(Pens.White, new Point(x, y), new Point(x + 1, y));
                    }
                    //if we don't have any
                    else
                    {
                        graphics.DrawLine(Pens.DarkCyan, new Point(x, y), new Point(x + 1, y));
                    }
                }
            }
        }
    }
}
