namespace VentasMostrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxUser
            // 
            textBoxUser.BackColor = Color.FromArgb(32, 47, 66);
            textBoxUser.BorderStyle = BorderStyle.FixedSingle;
            textBoxUser.Location = new Point(278, 73);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(291, 23);
            textBoxUser.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(32, 47, 66);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(278, 116);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(291, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(32, 47, 66);
            buttonLogin.BackgroundImageLayout = ImageLayout.None;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(278, 164);
            buttonLogin.Margin = new Padding(0, 0, 1, 1);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(291, 35);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Ingresar";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Location = new Point(571, 12);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(24, 23);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "X";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 47, 66);
            ClientSize = new Size(607, 228);
            ControlBox = false;
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonCancel;
    }
}