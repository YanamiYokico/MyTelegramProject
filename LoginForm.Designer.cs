namespace MyTelegramProject
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            rememberBox = new RoundedCheckBox();
            loginButton = new LoginButton();
            PassLabel = new Label();
            UsernameLabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(55, 55, 55);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(52, 121);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 42);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(55, 55, 55);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(52, 207);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(377, 42);
            textBox2.TabIndex = 1;
            // 
            // rememberBox
            // 
            rememberBox.AutoSize = true;
            rememberBox.BorderRadius = 6;
            rememberBox.BoxColor = Color.FromArgb(55, 55, 55);
            rememberBox.BoxSize = 12;
            rememberBox.CheckColor = Color.Green;
            rememberBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rememberBox.ForeColor = Color.FromArgb(55, 55, 55);
            rememberBox.Location = new Point(52, 283);
            rememberBox.Name = "rememberBox";
            rememberBox.Size = new Size(126, 24);
            rememberBox.TabIndex = 2;
            rememberBox.Text = "Remember me";
            rememberBox.TextColor = Color.FromArgb(200, 200, 200);
            rememberBox.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            loginButton.BorderRadius = 6;
            loginButton.EndColor = Color.FromArgb(0, 101, 255);
            loginButton.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(128, 314);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(229, 47);
            loginButton.StartColor = Color.FromArgb(0, 186, 255);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // PassLabel
            // 
            PassLabel.AutoSize = true;
            PassLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassLabel.ForeColor = SystemColors.ScrollBar;
            PassLabel.Location = new Point(52, 183);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new Size(76, 21);
            PassLabel.TabIndex = 4;
            PassLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.ForeColor = Color.FromArgb(0, 131, 255);
            UsernameLabel.Location = new Point(52, 97);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(194, 21);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "Login, using email address";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(708, 458);
            Controls.Add(UsernameLabel);
            Controls.Add(PassLabel);
            Controls.Add(rememberBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(loginButton);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private RoundedCheckBox rememberBox;
        private LoginButton loginButton;
        private Label PassLabel;
        private Label UsernameLabel;
    }
}