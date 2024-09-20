using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTelegramProject
{
    public class RoundedCheckBox : CheckBox
    {
        public int BorderRadius { get; set; } = 6;
        public int BoxSize { get; set; } = 12;

        public Color BoxColor { get; set; } = Color.FromArgb(55, 55, 55);
        public Color CheckColor { get; set; } = Color.Green;
        public Color TextColor { get; set; } = Color.FromArgb(200, 200, 200);

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.Clear(this.BackColor);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, BoxSize, BoxSize);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(rect.X + BoxSize - BorderRadius, rect.Y, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(rect.X + BoxSize - BorderRadius, rect.Y + BoxSize - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(rect.X, rect.Y + BoxSize - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            path.CloseFigure();

            using (SolidBrush brush = new SolidBrush(BoxColor))
            {
                pevent.Graphics.FillPath(brush, path);
            }

            if (this.Checked)
            {
                using (SolidBrush checkBrush = new SolidBrush(CheckColor))
                {
                    pevent.Graphics.FillPath(checkBrush, path);
                }
            }

            StringFormat sf = new StringFormat
            {
                LineAlignment = StringAlignment.Center
            };
            using (SolidBrush textBrush = new SolidBrush(TextColor))
            {
                pevent.Graphics.DrawString(this.Text, this.Font, textBrush, BoxSize + 10, (this.Height - BoxSize) / 2, sf);
            }
        }
    }

}
