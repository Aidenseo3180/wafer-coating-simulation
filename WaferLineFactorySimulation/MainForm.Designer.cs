namespace WaferLineFactorySimulation
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbox_ip = new System.Windows.Forms.ComboBox();
            this.tbox_port = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_line = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lb_next_no = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_selno = new System.Windows.Forms.Label();
            this.cb_awafer = new System.Windows.Forms.ComboBox();
            this.lb_spin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_drop = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_pr = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_line = new System.Windows.Forms.ComboBox();
            this.btn_manage = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts_lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.pn_awafer = new WaferLineControlLib.WaferPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_ip
            // 
            this.cbox_ip.FormattingEnabled = true;
            this.cbox_ip.Location = new System.Drawing.Point(45, 40);
            this.cbox_ip.Name = "cbox_ip";
            this.cbox_ip.Size = new System.Drawing.Size(500, 39);
            this.cbox_ip.TabIndex = 0;
            // 
            // tbox_port
            // 
            this.tbox_port.Location = new System.Drawing.Point(587, 41);
            this.tbox_port.Name = "tbox_port";
            this.tbox_port.Size = new System.Drawing.Size(308, 38);
            this.tbox_port.TabIndex = 1;
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(948, 30);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(195, 59);
            this.btn_set.TabIndex = 2;
            this.btn_set.Text = "Setting";
            this.btn_set.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Line";
            // 
            // lv_line
            // 
            this.lv_line.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_line.FullRowSelect = true;
            this.lv_line.HideSelection = false;
            this.lv_line.Location = new System.Drawing.Point(45, 168);
            this.lv_line.MultiSelect = false;
            this.lv_line.Name = "lv_line";
            this.lv_line.Size = new System.Drawing.Size(415, 435);
            this.lv_line.TabIndex = 4;
            this.lv_line.UseCompatibleStateImageBehavior = false;
            this.lv_line.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Before Coating";
            this.columnHeader2.Width = 199;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Coated";
            this.columnHeader3.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Next Line:";
            // 
            // lb_next_no
            // 
            this.lb_next_no.AutoSize = true;
            this.lb_next_no.Location = new System.Drawing.Point(193, 638);
            this.lb_next_no.Name = "lb_next_no";
            this.lb_next_no.Size = new System.Drawing.Size(30, 32);
            this.lb_next_no.TabIndex = 6;
            this.lb_next_no.Text = "1";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(299, 627);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(161, 53);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selected Line:";
            // 
            // lb_selno
            // 
            this.lb_selno.AutoSize = true;
            this.lb_selno.Location = new System.Drawing.Point(722, 136);
            this.lb_selno.Name = "lb_selno";
            this.lb_selno.Size = new System.Drawing.Size(30, 32);
            this.lb_selno.TabIndex = 9;
            this.lb_selno.Text = "0";
            // 
            // cb_awafer
            // 
            this.cb_awafer.FormattingEnabled = true;
            this.cb_awafer.Location = new System.Drawing.Point(532, 185);
            this.cb_awafer.Name = "cb_awafer";
            this.cb_awafer.Size = new System.Drawing.Size(341, 39);
            this.cb_awafer.TabIndex = 10;
            this.cb_awafer.SelectedIndexChanged += new System.EventHandler(this.cb_awafer_SelectedIndexChanged);
            // 
            // lb_spin
            // 
            this.lb_spin.AutoSize = true;
            this.lb_spin.Location = new System.Drawing.Point(1125, 273);
            this.lb_spin.Name = "lb_spin";
            this.lb_spin.Size = new System.Drawing.Size(78, 32);
            this.lb_spin.TabIndex = 13;
            this.lb_spin.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(915, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Spin:";
            // 
            // lb_drop
            // 
            this.lb_drop.AutoSize = true;
            this.lb_drop.Location = new System.Drawing.Point(1126, 329);
            this.lb_drop.Name = "lb_drop";
            this.lb_drop.Size = new System.Drawing.Size(46, 32);
            this.lb_drop.TabIndex = 15;
            this.lb_drop.Text = "20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(915, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Drop:";
            // 
            // lb_pr
            // 
            this.lb_pr.AutoSize = true;
            this.lb_pr.Location = new System.Drawing.Point(1127, 379);
            this.lb_pr.Name = "lb_pr";
            this.lb_pr.Size = new System.Drawing.Size(30, 32);
            this.lb_pr.TabIndex = 17;
            this.lb_pr.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(917, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 32);
            this.label11.TabIndex = 16;
            this.label11.Text = "Coating Liquid:";
            // 
            // cb_line
            // 
            this.cb_line.FormattingEnabled = true;
            this.cb_line.Location = new System.Drawing.Point(521, 631);
            this.cb_line.Name = "cb_line";
            this.cb_line.Size = new System.Drawing.Size(352, 39);
            this.cb_line.TabIndex = 18;
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(923, 622);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(189, 62);
            this.btn_manage.TabIndex = 19;
            this.btn_manage.Text = "Manage";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_lb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 714);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1290, 54);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts_lb
            // 
            this.ts_lb.Name = "ts_lb";
            this.ts_lb.Size = new System.Drawing.Size(418, 41);
            this.ts_lb.Text = "Displays most recent changes.";
            // 
            // pn_awafer
            // 
            this.pn_awafer.Location = new System.Drawing.Point(544, 273);
            this.pn_awafer.Name = "pn_awafer";
            this.pn_awafer.Size = new System.Drawing.Size(310, 320);
            this.pn_awafer.TabIndex = 11;
            this.pn_awafer.Wafer = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1206, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "rpm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1207, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "ps";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 768);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.cb_line);
            this.Controls.Add(this.lb_pr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_drop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_spin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pn_awafer);
            this.Controls.Add(this.cb_awafer);
            this.Controls.Add(this.lb_selno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_next_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_line);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.tbox_port);
            this.Controls.Add(this.cbox_ip);
            this.Name = "MainForm";
            this.Text = "WaferLine Factory Main Form";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_ip;
        private System.Windows.Forms.TextBox tbox_port;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_line;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_next_no;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_selno;
        private System.Windows.Forms.ComboBox cb_awafer;
        private WaferLineControlLib.WaferPanel pn_awafer;
        private System.Windows.Forms.Label lb_spin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_drop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_pr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_line;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

