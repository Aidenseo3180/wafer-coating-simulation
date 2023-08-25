﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaferLineLib;

namespace WaferLineControlLib
{
    public class WaferPanel:DPanel
    {
        public Wafer Wafer { get; set; }

        public WaferPanel()
        {
            this.Paint += WaferPanel_Paint;
        }

        private void WaferPanel_Paint(object sender, PaintEventArgs e)
        {
            //to display the wafer panel
            Graphics graphics = e.Graphics;
            Brush brush = Brushes.Silver;

            //define and fill eclipse (disc) of pn_wafer
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            graphics.FillEllipse(brush, rect);

            //within the wafer disc, create rectangle where 100 cells will be located (big rectangular outline that covers 100 cells)
            int width = this.Width;
            int height = this.Height;
            int sx = (int)(width * 0.15);
            int sy = (int)(height * 0.15);
            Rectangle rect2 = new Rectangle(sx, sy, (int)(width * 0.7), (int)(height * 0.7));
            graphics.DrawRectangle(Pens.Red, rect2);

            //for 100 cells (dicing)
            int xu = rect2.Width / 10;
            int yu = rect2.Height / 10;
            Pen pen = new Pen(Color.DarkGray, 1);
            //draw 9 lines for 10 cells (from x-axis, top to bottom)
            //in order to create 10 cells, only need to draw 9 lines (since border already exists)
            for (int x = 1; x < 10; x++)
            {
                graphics.DrawLine(pen, new Point(sx + x * xu, sy), new Point(sx + x * xu, sy + rect2.Height));
            }
            //draw 9 lines for 10 cells (from y-axis, left to right)
            for (int y = 1; y < 10; y++)
            {
                graphics.DrawLine(pen, new Point(sx, sy + y * yu), new Point(sx + rect2.Width, sy + y * yu));
            }

            //if there's no wafer
            if (Wafer == null)
            {
                return;
            }

            //draw on dicing from center
            int dir = 0;
            int step = 1, nowstep = step;   //nowstep is # of steps you can move without changing direction
            int nx = 4, ny = 5; //starting at center position
            for (int i = 0; i < 100; i++)
            {
                int qual = Wafer[i];
                Color color = Color.FromArgb(200 - qual * 2, 55 + qual * 2, 0); //as quality increase, less R & more G the color gets
                Rectangle rt = new Rectangle(sx + nx * xu + 1, sy + ny * yu + 1, xu - 1, yu - 1);   //each cell, +1 and -1 for lines
                graphics.FillRectangle(new SolidBrush(color), rt);
                if (nowstep == 0)
                {
                    //0, 1, 2, 3 so 4 directions available
                    dir = (dir + 1) % 4;
                    //if changes direction twice, 1 more cell should be added
                    if (dir % 2 == 0)
                    {
                        step++;
                    }
                    nowstep = step;
                }
                nowstep--;  //if not changing direction, then decrement nowstep to reduce # of cells left without changing direction
                switch (dir)
                {
                    case 0:
                        //move up
                        ny--; break;
                    case 1:
                        //move right
                        nx++; break;
                    case 2:
                        //move downward
                        ny++; break;
                    case 3:
                        //move left
                        nx--; break;
                }
            }
        }
    }
}
