using System;
using System.Collections;
using System.Collections.Generic;
using WaferLineLib;

namespace WaferLineLib
{
    //inherit IEnumerable to be able to iterate Wafer objects
    public class WaferLine : IEnumerable<Wafer>
    {
        //Add and define Events as a class member
        //Call these events within other methods when some event occurs
        public event AddWaferEventHandler AddedWafer;
        public event AddPREventHandler AddedPR;
        public event SetSpinEventHandler SetSpinRate;
        public event SetDropEventHandler SetDropRate;
        public event EndPREventHandler EndedPR;
        public event EndCoatingEventHandler EndedCoating;

        public int No { get; }

        /// <summary>
        /// Spin Rate
        /// </summary>
        public int Spin
        {
            get;
            set;
        }

        //drop rate
        public int Drop
        {
            get;
            set;
        }

        public WaferLine(int no)
        {
            No = no;
            Spin = 1000;
            Drop = 20;
        }

        //list of wafers before coating
        List<Wafer> bwafers = new List<Wafer>();
        //list of wafers after coating
        List<Wafer> awafers = new List<Wafer>();

        //most recently coated wafer
        public Wafer LastWafer
        {
            get
            {
                if (awafers.Count == 0) //meaning there's no coated wafers
                {
                    return null;
                }
                //return most recently finished wafer
                return awafers[awafers.Count - 1];
            }
        }

        //when coating is done, display number of non-coated/coated wafers
        public void EndCoating(int bwcnt, int awcnt)
        {
            //update bwafers. If bwcnt < Count, that means bwafers must be updated (so remove the one that has been recently coated)
            while (bwafers.Count > bwcnt)
            {
                bwafers.RemoveAt(0);
            }
            //if awafers is lower than awcnt, that means awafers must be updated with coated wafer
            while (awafers.Count < awcnt)
            {
                awafers.Add(null);
            }
        }

        Wafer nwafer;    //single wafer that we're curretly working on
        int nowp;       //coating liquid, 1 bottle can coat 1000 cells
        public Wafer Now
        {
            get { return nwafer; }
        }

        //current # of non-coated wafers (before wafer)
        public int BWCnt
        {
            get { return bwafers.Count; }
        }

        //add wafers through wcnt to non-coated wafers
        public int InWafer(int wcnt)
        {
            //available amount of non-coated wafers you can provide
            int avail = 200 - BWCnt;
            if (wcnt > avail)
            {
                wcnt = avail;
            }

            for (int i = 0; i < wcnt; i++)
            {
                bwafers.Add(new Wafer());
            }

            //When all the InWafer works are finished, check if event exists
            if (AddedWafer != null)
            {
                //call delegate like this
                AddedWafer(this, new AddWaferEventArgs(No, BWCnt));
            }

            //return # of bwafers after adding
            return bwafers.Count;
        }

        public int AWCnt
        {
            get { return awafers.Count; }
        }

        //# of current coating liquid
        public int PCnt
        {
            get; set;
        }

        //how many cells can current coating liquid coat
        public int NPCnt
        {
            get { return nowp; }
        }

        //provide more coating liquid bottles through pcnt
        public int InPr(int pcnt)
        {
            int avail = 20 - PCnt;
            if (pcnt > avail)
            {
                pcnt = avail;
            }

            PCnt += pcnt;

            //When all the works are finished, check if event exists
            if (AddedPR != null)
            {
                AddedPR(this, new AddPREventArgs(No, PCnt));
            }

            return PCnt;    //return # of coating liquid after adding
        }

        public void SetSpin(int spin)
        {
            Spin = spin;

            if (SetSpinRate != null)
            {
                SetSpinRate(this, new SetSpinEventArgs(No, spin));
            }
        }

        public void SetDrop(int drop)
        {
            Drop = drop;

            if (SetDropRate != null)
            {
                SetDropRate(this, new SetDropEventArgs(No, drop));
            }
        }

        Random rand = new Random();
        public bool Coating()
        {
            //check if # of cells we can coat with current coating liquid is 0,
            if (nowp == 0)
            {
                //since coating liquid is empty, has to bring new liquid bottle
                if (EndedPR != null)
                {
                    EndedPR(this, new EndPREventArgs(No));
                }

                //check if there's coating liquid bottles (each can coat 1000)
                if (PCnt == 0)
                {
                    return false;   //can't coat
                }

                nowp = 1000;
                PCnt--; //-1 bottle
            }

            //if there's no current wafer to coat
            if (nwafer == null)
            {
                //and there's no non-coated wafers
                if (bwafers.Count == 0)
                {
                    return false;
                }

                nwafer = bwafers[0];
                bwafers.RemoveAt(0);

            }

            nwafer.Coating(rand.Next(70, 100));
            nowp--; //1 cell coated, so -1

            //if can't be incremented (meaning coating wafer has been completed)
            if (nwafer.Increment() == false)
            {
                awafers.Add(nwafer);
                nwafer = null;

                if (EndedCoating != null)
                {
                    EndedCoating(this, new EndCoatingEventArgs(No, BWCnt, AWCnt));
                }
            }

            return true;
        }

        public override string ToString()
        {
            return string.Format("WaferLine: {0}", No);
        }

        public IEnumerator<Wafer> GetEnumerator()
        {
            return awafers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return awafers.GetEnumerator();
        }
    }

}
