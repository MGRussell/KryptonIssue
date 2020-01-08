using System;
using System.Drawing;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace KryptonIssue
{
    class SimpleGLControl : GLControl
    {
        public SimpleGLControl()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            if (!this.DesignMode)
            {
                MakeCurrent();
                GL.ClearColor(Color.Aquamarine);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!this.DesignMode)
            
            {
                MakeCurrent();

                GL.Clear(ClearBufferMask.ColorBufferBit);
                SwapBuffers();
            }
        }
    }
}
