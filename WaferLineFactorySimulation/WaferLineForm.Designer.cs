namespace WaferLineFactorySimulation
{
    partial class WaferLineForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_no = new System.Windows.Forms.Label();
            this.wlc = new WaferLineControlLib.WaferLineControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "WaferLine No:";
            // 
            // lb_no
            // 
            this.lb_no.AutoSize = true;
            this.lb_no.Location = new System.Drawing.Point(268, 52);
            this.lb_no.Name = "lb_no";
            this.lb_no.Size = new System.Drawing.Size(50, 32);
            this.lb_no.TabIndex = 2;
            this.lb_no.Text = "No";
            // 
            // wlc
            // 
            this.wlc.Line = null;
            this.wlc.Location = new System.Drawing.Point(-1, 123);
            this.wlc.Name = "wlc";
            this.wlc.Size = new System.Drawing.Size(1756, 965);
            this.wlc.TabIndex = 3;
            // 
            // WaferLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 1091);
            this.Controls.Add(this.wlc);
            this.Controls.Add(this.lb_no);
            this.Controls.Add(this.label1);
            this.Name = "WaferLineForm";
            this.Text = "WaferLineForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WaferLineForm_FormClosing);
            this.Load += new System.EventHandler(this.WaferLineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_no;
        private WaferLineControlLib.WaferLineControl wlc;
    }
}