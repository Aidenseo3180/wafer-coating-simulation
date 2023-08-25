namespace WaferLineControlLib
{
    partial class WaferLineControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts_lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.cb_awafer = new System.Windows.Forms.ComboBox();
            this.lb_awcnt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.lb_pcnt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tm_coating = new System.Windows.Forms.Timer(this.components);
            this.lb_wcnt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_drop = new System.Windows.Forms.Label();
            this.tbar_drop = new System.Windows.Forms.TrackBar();
            this.lb_spin = new System.Windows.Forms.Label();
            this.tbar_spin = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_pr = new System.Windows.Forms.Button();
            this.lb_pr = new System.Windows.Forms.Label();
            this.tbar_pr = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_wafer = new System.Windows.Forms.Button();
            this.lb_wafer = new System.Windows.Forms.Label();
            this.tbar_wafer = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_awafer = new WaferLineControlLib.WaferPanel();
            this.pn_nwafer = new WaferLineControlLib.WaferPanel();
            this.pn_npr = new WaferLineControlLib.DPanel();
            this.pn_pr = new WaferLineControlLib.DPanel();
            this.pn_wafer = new WaferLineControlLib.DPanel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_drop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_spin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_pr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_wafer)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_lb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 911);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1756, 54);
            this.statusStrip1.TabIndex = 59;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts_lb
            // 
            this.ts_lb.Name = "ts_lb";
            this.ts_lb.Size = new System.Drawing.Size(308, 41);
            this.ts_lb.Text = "Displays current state.";
            // 
            // cb_awafer
            // 
            this.cb_awafer.FormattingEnabled = true;
            this.cb_awafer.Location = new System.Drawing.Point(1307, 373);
            this.cb_awafer.Name = "cb_awafer";
            this.cb_awafer.Size = new System.Drawing.Size(326, 39);
            this.cb_awafer.TabIndex = 57;
            this.cb_awafer.SelectedIndexChanged += new System.EventHandler(this.cb_awafer_SelectedIndexChanged);
            // 
            // lb_awcnt
            // 
            this.lb_awcnt.AutoSize = true;
            this.lb_awcnt.Location = new System.Drawing.Point(1562, 305);
            this.lb_awcnt.Name = "lb_awcnt";
            this.lb_awcnt.Size = new System.Drawing.Size(30, 32);
            this.lb_awcnt.TabIndex = 56;
            this.lb_awcnt.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1338, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 32);
            this.label8.TabIndex = 55;
            this.label8.Text = "Wafer (After)";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(919, 282);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(129, 55);
            this.btn_start.TabIndex = 52;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lb_pcnt
            // 
            this.lb_pcnt.AutoSize = true;
            this.lb_pcnt.Location = new System.Drawing.Point(532, 362);
            this.lb_pcnt.Name = "lb_pcnt";
            this.lb_pcnt.Size = new System.Drawing.Size(30, 32);
            this.lb_pcnt.TabIndex = 50;
            this.lb_pcnt.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 32);
            this.label9.TabIndex = 49;
            this.label9.Text = "Coating Liquid";
            // 
            // tm_coating
            // 
            this.tm_coating.Tick += new System.EventHandler(this.tm_coating_Tick);
            // 
            // lb_wcnt
            // 
            this.lb_wcnt.AutoSize = true;
            this.lb_wcnt.Location = new System.Drawing.Point(177, 362);
            this.lb_wcnt.Name = "lb_wcnt";
            this.lb_wcnt.Size = new System.Drawing.Size(30, 32);
            this.lb_wcnt.TabIndex = 47;
            this.lb_wcnt.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1576, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 32);
            this.label5.TabIndex = 45;
            this.label5.Text = "ps";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 32);
            this.label7.TabIndex = 46;
            this.label7.Text = "Uncoated Wafer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1571, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 32);
            this.label6.TabIndex = 44;
            this.label6.Text = "rpm";
            // 
            // lb_drop
            // 
            this.lb_drop.AutoSize = true;
            this.lb_drop.Location = new System.Drawing.Point(1505, 143);
            this.lb_drop.Name = "lb_drop";
            this.lb_drop.Size = new System.Drawing.Size(46, 32);
            this.lb_drop.TabIndex = 43;
            this.lb_drop.Text = "20";
            // 
            // tbar_drop
            // 
            this.tbar_drop.Location = new System.Drawing.Point(1114, 128);
            this.tbar_drop.Maximum = 100;
            this.tbar_drop.Minimum = 20;
            this.tbar_drop.Name = "tbar_drop";
            this.tbar_drop.Size = new System.Drawing.Size(341, 114);
            this.tbar_drop.TabIndex = 42;
            this.tbar_drop.Value = 20;
            this.tbar_drop.Scroll += new System.EventHandler(this.tbar_drop_Scroll);
            // 
            // lb_spin
            // 
            this.lb_spin.AutoSize = true;
            this.lb_spin.Location = new System.Drawing.Point(1487, 44);
            this.lb_spin.Name = "lb_spin";
            this.lb_spin.Size = new System.Drawing.Size(78, 32);
            this.lb_spin.TabIndex = 41;
            this.lb_spin.Text = "1000";
            // 
            // tbar_spin
            // 
            this.tbar_spin.Location = new System.Drawing.Point(1114, 23);
            this.tbar_spin.Maximum = 8000;
            this.tbar_spin.Minimum = 1000;
            this.tbar_spin.Name = "tbar_spin";
            this.tbar_spin.Size = new System.Drawing.Size(341, 114);
            this.tbar_spin.TabIndex = 40;
            this.tbar_spin.Value = 1000;
            this.tbar_spin.Scroll += new System.EventHandler(this.tbar_spin_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(913, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Drop Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(916, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "Spin Rate";
            // 
            // btn_pr
            // 
            this.btn_pr.Location = new System.Drawing.Point(637, 128);
            this.btn_pr.Name = "btn_pr";
            this.btn_pr.Size = new System.Drawing.Size(129, 55);
            this.btn_pr.TabIndex = 37;
            this.btn_pr.Text = "Insert";
            this.btn_pr.UseVisualStyleBackColor = true;
            this.btn_pr.Click += new System.EventHandler(this.btn_pr_Click);
            // 
            // lb_pr
            // 
            this.lb_pr.AutoSize = true;
            this.lb_pr.Location = new System.Drawing.Point(564, 140);
            this.lb_pr.Name = "lb_pr";
            this.lb_pr.Size = new System.Drawing.Size(30, 32);
            this.lb_pr.TabIndex = 36;
            this.lb_pr.Text = "0";
            // 
            // tbar_pr
            // 
            this.tbar_pr.Location = new System.Drawing.Point(224, 130);
            this.tbar_pr.Maximum = 20;
            this.tbar_pr.Name = "tbar_pr";
            this.tbar_pr.Size = new System.Drawing.Size(334, 114);
            this.tbar_pr.TabIndex = 35;
            this.tbar_pr.Scroll += new System.EventHandler(this.tbar_pr_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 32);
            this.label3.TabIndex = 34;
            this.label3.Text = "Coating Liquid";
            // 
            // btn_wafer
            // 
            this.btn_wafer.Location = new System.Drawing.Point(637, 21);
            this.btn_wafer.Name = "btn_wafer";
            this.btn_wafer.Size = new System.Drawing.Size(129, 55);
            this.btn_wafer.TabIndex = 33;
            this.btn_wafer.Text = "Insert";
            this.btn_wafer.UseVisualStyleBackColor = true;
            this.btn_wafer.Click += new System.EventHandler(this.btn_wafer_Click);
            // 
            // lb_wafer
            // 
            this.lb_wafer.AutoSize = true;
            this.lb_wafer.Location = new System.Drawing.Point(564, 36);
            this.lb_wafer.Name = "lb_wafer";
            this.lb_wafer.Size = new System.Drawing.Size(30, 32);
            this.lb_wafer.TabIndex = 32;
            this.lb_wafer.Text = "0";
            // 
            // tbar_wafer
            // 
            this.tbar_wafer.Location = new System.Drawing.Point(224, 23);
            this.tbar_wafer.Maximum = 200;
            this.tbar_wafer.Name = "tbar_wafer";
            this.tbar_wafer.Size = new System.Drawing.Size(334, 114);
            this.tbar_wafer.TabIndex = 31;
            this.tbar_wafer.Scroll += new System.EventHandler(this.tbar_wafer_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Wafer";
            // 
            // pn_awafer
            // 
            this.pn_awafer.Location = new System.Drawing.Point(1275, 487);
            this.pn_awafer.Name = "pn_awafer";
            this.pn_awafer.Size = new System.Drawing.Size(385, 380);
            this.pn_awafer.TabIndex = 58;
            this.pn_awafer.Wafer = null;
            // 
            // pn_nwafer
            // 
            this.pn_nwafer.Location = new System.Drawing.Point(786, 487);
            this.pn_nwafer.Name = "pn_nwafer";
            this.pn_nwafer.Size = new System.Drawing.Size(385, 380);
            this.pn_nwafer.TabIndex = 54;
            this.pn_nwafer.Wafer = null;
            // 
            // pn_npr
            // 
            this.pn_npr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_npr.Location = new System.Drawing.Point(922, 362);
            this.pn_npr.Name = "pn_npr";
            this.pn_npr.Size = new System.Drawing.Size(120, 50);
            this.pn_npr.TabIndex = 53;
            this.pn_npr.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_npr_Paint);
            // 
            // pn_pr
            // 
            this.pn_pr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_pr.Location = new System.Drawing.Point(403, 432);
            this.pn_pr.Name = "pn_pr";
            this.pn_pr.Size = new System.Drawing.Size(300, 430);
            this.pn_pr.TabIndex = 51;
            this.pn_pr.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_pr_Paint);
            // 
            // pn_wafer
            // 
            this.pn_wafer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_wafer.Location = new System.Drawing.Point(48, 432);
            this.pn_wafer.Name = "pn_wafer";
            this.pn_wafer.Size = new System.Drawing.Size(300, 430);
            this.pn_wafer.TabIndex = 48;
            this.pn_wafer.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_wafer_Paint);
            // 
            // WaferLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pn_awafer);
            this.Controls.Add(this.cb_awafer);
            this.Controls.Add(this.lb_awcnt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pn_nwafer);
            this.Controls.Add(this.pn_npr);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pn_pr);
            this.Controls.Add(this.lb_pcnt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pn_wafer);
            this.Controls.Add(this.lb_wcnt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_drop);
            this.Controls.Add(this.tbar_drop);
            this.Controls.Add(this.lb_spin);
            this.Controls.Add(this.tbar_spin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_pr);
            this.Controls.Add(this.lb_pr);
            this.Controls.Add(this.tbar_pr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_wafer);
            this.Controls.Add(this.lb_wafer);
            this.Controls.Add(this.tbar_wafer);
            this.Controls.Add(this.label1);
            this.Name = "WaferLineControl";
            this.Size = new System.Drawing.Size(1756, 965);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_drop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_spin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_pr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_wafer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts_lb;
        private WaferPanel pn_awafer;
        private System.Windows.Forms.ComboBox cb_awafer;
        private System.Windows.Forms.Label lb_awcnt;
        private System.Windows.Forms.Label label8;
        private WaferPanel pn_nwafer;
        private DPanel pn_npr;
        private System.Windows.Forms.Button btn_start;
        private DPanel pn_pr;
        private System.Windows.Forms.Label lb_pcnt;
        private System.Windows.Forms.Label label9;
        private DPanel pn_wafer;
        private System.Windows.Forms.Timer tm_coating;
        private System.Windows.Forms.Label lb_wcnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_drop;
        private System.Windows.Forms.TrackBar tbar_drop;
        private System.Windows.Forms.Label lb_spin;
        private System.Windows.Forms.TrackBar tbar_spin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_pr;
        private System.Windows.Forms.Label lb_pr;
        private System.Windows.Forms.TrackBar tbar_pr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_wafer;
        private System.Windows.Forms.Label lb_wafer;
        private System.Windows.Forms.TrackBar tbar_wafer;
        private System.Windows.Forms.Label label1;
    }
}
