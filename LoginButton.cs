using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTelegramProject
{
    public class LoginButton : Button
    {
        public Color StartColor { get; set; } = Color.FromArgb(0, 186, 255);
        public Color EndColor { get; set; } = Color.FromArgb(0, 101, 255);
        public int BorderRadius { get; set; } = 6;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.Clear(this.Parent.BackColor);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, StartColor, EndColor, LinearGradientMode.Horizontal))
            {
                GraphicsPath path = new GraphicsPath();
                float diameter = BorderRadius * 2;
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                pevent.Graphics.FillPath(brush, path);
            }

            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
