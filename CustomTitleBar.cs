using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTelegramProject
{
    public class CustomTitleBar : Panel
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public CustomTitleBar()
        {
            this.BackColor = Color.FromArgb(33, 33, 33);
            this.Dock = DockStyle.Top;
            this.Height = 30;

            Button closeButton = new Button
            {
                Text = "✖",
                Dock = DockStyle.Right,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(33, 33, 33),
                FlatAppearance =
            {
                BorderSize = 0
            }
            };

            closeButton.MouseEnter += (s, e) =>
            {
                closeButton.BackColor = Color.Red;
            };
            closeButton.MouseLeave += (s, e) =>
            {
                closeButton.BackColor = Color.FromArgb(33, 33, 33);
            };

            closeButton.Click += (s, e) => OnCloseButtonClick();
            this.Controls.Add(closeButton);

            this.MouseDown += CustomTitleBar_MouseDown;
            this.MouseMove += CustomTitleBar_MouseMove;
            this.MouseUp += CustomTitleBar_MouseUp;
        }

        public event EventHandler CloseButtonClick;

        private void OnCloseButtonClick()
        {
            CloseButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void CustomTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.FindForm().Location;
            }
        }

        private void CustomTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.FindForm().Location = Point.Add(lastForm, new Size(delta));
            }
        }

        private void CustomTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }

}
