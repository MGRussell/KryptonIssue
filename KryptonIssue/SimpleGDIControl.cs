using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace KryptonIssue
{
    class SimpleGDIControl : Control
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;
            LinearGradientBrush lBrush = new LinearGradientBrush(ClientRectangle, Color.Red, Color.Yellow, LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lBrush, ClientRectangle);
        }
    }
}
