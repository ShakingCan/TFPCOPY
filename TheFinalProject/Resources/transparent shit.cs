using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFinalProject.Resources
{
    public class transparent_shit : Panel
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // 0x20 is WS_EX_TRANSPARENT, forcing Windows to paint whatever is 
                // physically behind this control first before drawing the control itself.
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Do absolutely nothing here. Do not paint the parent's color!
        }
    }
}
