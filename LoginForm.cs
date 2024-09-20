using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTelegramProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            CustomTitleBar titleBar = new CustomTitleBar();
            titleBar.Dock = DockStyle.Top;
            titleBar.CloseButtonClick += (s, e) => this.Close();
            Controls.Add(titleBar);
        }
    }
}
