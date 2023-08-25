using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferLineLib
{
    /// <summary>
    /// Wafer Class
    /// </summary>
    public class Wafer
    {
        static int last_wn;         //most recently given wafer number
        readonly int wn;            //wafer number set as readonly
        int[] cells = new int[100]; //wafer composed of 100 cells
        int now;                    //cell of wafer that is currently processing
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Wafer()
        {
            last_wn++;
            wn = last_wn;
        }

        /// <summary>
        /// Get the index of cell that will be coated
        /// </summary>
        public int Now
        {
            get { return now; }
        }

        /// <summary>
        /// Increment coating cell number
        /// </summary>
        /// <returns>Increment success state</returns>
        public bool Increment()
        {
            if (now < 100)
            {
                now++;
                if (now == 100)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Coating method
        /// </summary>
        /// <param name="quality">Amount of quality given to cell</param>
        public void Coating(int quality)
        {
            if (Now < cells.Length)
            {
                cells[Now] = quality;
            }
        }

        /// <summary>
        /// check quality of each index of cells
        /// </summary>
        /// <param name="index">index of cell</param>
        /// <returns>corresponding quality</returns>
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= cells.Length)
                {
                    return 0;
                }

                return cells[index];
            }
        }

        /// <summary>
        /// overall wafer quality (all cells combined)
        /// </summary>
        public double Quality
        {
            get
            {
                int sum = 0;
                foreach (int elem in cells)
                {
                    sum += elem;
                }
                return sum / 100.0;
            }
        }

        /// <summary>
        /// ToString method re-defined
        /// </summary>
        /// <returns>Wafer number and corresponding quality</returns>
        public override string ToString()
        {
            return string.Format("No.{0}, Quality:{1}", wn, Quality);
        }
    }
}
