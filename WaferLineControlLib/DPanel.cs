using System.Windows.Forms;

namespace WaferLineControlLib
{
    //Since drawing has lowest priority in Windows, make double buffer to priortize it by reassinging style
    //Since form can perform double buffering but panel can't, make our own panle that can do it
    //double buffering allows the control to be first drawn
    public class DPanel : Panel
    {
        public DPanel()
        {
            //set the style
            SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer |
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }

    }
}
