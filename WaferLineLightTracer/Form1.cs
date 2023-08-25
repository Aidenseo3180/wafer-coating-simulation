using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaferLineLib;

namespace WaferLineLightTracer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //when the form gets loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            //this is the library that we're importing from WaterLineLib (library) - WaferLine.cs
            //basically initializing it when the form gets loaded
            waferLineControl1.Line = new WaferLine(1);
        }



    }
}
