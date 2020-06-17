using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHomework_Game
{
    public partial class CustomProgressBar : System.Windows.Forms.ProgressBar
    {
        private Font font = System.Drawing.SystemFonts.DefaultFont;

        public CustomProgressBar()
        {
            SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;

            ControlPaint.DrawBorder(g, this.ClientRectangle, Color.DarkGray, ButtonBorderStyle.Solid);

            int total = this.Maximum - this.Minimum;
            int current = this.Value - this.Minimum;
            Rectangle currentRect = new Rectangle();
            int percentage = (int)Math.Ceiling((double)current / total * 100);

            currentRect.X = 1;
            currentRect.Y = 1;
            currentRect.Width = (int)((double)percentage / (double)100 * (this.Width - 2));
            currentRect.Height = this.Height - 2;

            using (SolidBrush objBrush = new SolidBrush(this.ForeColor))
            {
                g.FillRectangle(objBrush, currentRect);
            }
        }
    }
}
