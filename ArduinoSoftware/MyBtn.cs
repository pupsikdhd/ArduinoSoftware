using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace customBtnTest
{
    public class MyBtn : Control
    {
        private StringFormat stringFormat = new StringFormat();
        private bool MouseEntered = false;
        private bool MousePressed = false;


        public Color BorderColorOnHover { get; set; }
        public byte alphaOnHover { get; set; }
        public MyBtn()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new System.Drawing.Size(10, 50);
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);

            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            graph.DrawRectangle(new Pen(BackColor), rectangle);
            graph.FillRectangle(new SolidBrush(BackColor), rectangle);
            if (MouseEntered)
            {

                //graph.DrawRectangle(new Pen(Color.FromArgb(52,Color.Blue)),rectangle);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(alphaOnHover, Color.Transparent)), rectangle);
                ControlPaint.DrawBorder(e.Graphics, ClientRectangle, BorderColorOnHover, ButtonBorderStyle.Solid);

            }

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rectangle, stringFormat);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = false;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePressed = true;
        }
    }
}
