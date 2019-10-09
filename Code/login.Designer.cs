namespace Algebraic_calculator_v0
{
    partial class login
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.signIn = new MetroFramework.Controls.MetroButton();
            this.skipButton = new MetroFramework.Controls.MetroButton();
            this.password1 = new MetroFramework.Controls.MetroTextBox();
            this.username1 = new MetroFramework.Controls.MetroTextBox();
            this.registerButton = new MetroFramework.Controls.MetroButton();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // signIn
            // 
            this.signIn.Highlight = true;
            this.signIn.Location = new System.Drawing.Point(270, 175);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(75, 34);
            this.signIn.TabIndex = 9;
            this.signIn.Text = "Sign In";
            this.signIn.UseSelectable = true;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // skipButton
            // 
            this.skipButton.Highlight = true;
            this.skipButton.Location = new System.Drawing.Point(270, 225);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(75, 31);
            this.skipButton.TabIndex = 10;
            this.skipButton.Text = "Skip";
            this.skipButton.UseSelectable = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // password1
            // 
            // 
            // 
            // 
            this.password1.CustomButton.Image = null;
            this.password1.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.password1.CustomButton.Name = "";
            this.password1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.password1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password1.CustomButton.TabIndex = 1;
            this.password1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password1.CustomButton.UseSelectable = true;
            this.password1.CustomButton.Visible = false;
            this.password1.DisplayIcon = true;
            this.password1.Icon = global::Algebraic_calculator_v0.Properties.Resources.passwordicon;
            this.password1.Lines = new string[0];
            this.password1.Location = new System.Drawing.Point(130, 136);
            this.password1.MaxLength = 32767;
            this.password1.Name = "password1";
            this.password1.PasswordChar = '•';
            this.password1.PromptText = "Password";
            this.password1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password1.SelectedText = "";
            this.password1.SelectionLength = 0;
            this.password1.SelectionStart = 0;
            this.password1.ShortcutsEnabled = true;
            this.password1.Size = new System.Drawing.Size(215, 25);
            this.password1.TabIndex = 8;
            this.password1.UseSelectable = true;
            this.password1.WaterMark = "Password";
            this.password1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // username1
            // 
            // 
            // 
            // 
            this.username1.CustomButton.BackColor = System.Drawing.Color.White;
            this.username1.CustomButton.Image = null;
            this.username1.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.username1.CustomButton.Name = "";
            this.username1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.username1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username1.CustomButton.TabIndex = 1;
            this.username1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username1.CustomButton.UseSelectable = true;
            this.username1.CustomButton.UseVisualStyleBackColor = false;
            this.username1.CustomButton.Visible = false;
            this.username1.DisplayIcon = true;
            this.username1.Icon = global::Algebraic_calculator_v0.Properties.Resources.multy_user;
            this.username1.Lines = new string[0];
            this.username1.Location = new System.Drawing.Point(130, 81);
            this.username1.MaxLength = 32767;
            this.username1.Name = "username1";
            this.username1.PasswordChar = '\0';
            this.username1.PromptText = "Username";
            this.username1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username1.SelectedText = "";
            this.username1.SelectionLength = 0;
            this.username1.SelectionStart = 0;
            this.username1.ShortcutsEnabled = true;
            this.username1.Size = new System.Drawing.Size(215, 25);
            this.username1.TabIndex = 7;
            this.username1.UseSelectable = true;
            this.username1.WaterMark = "Username";
            this.username1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // registerButton
            // 
            this.registerButton.Highlight = true;
            this.registerButton.Location = new System.Drawing.Point(186, 175);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(78, 34);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Register";
            this.registerButton.UseSelectable = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Highlight = true;
            this.exitButton.Location = new System.Drawing.Point(23, 225);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 31);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseSelectable = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // login
            // 
            this.AcceptButton = this.signIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(417, 294);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "Sign in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public MetroFramework.Controls.MetroTextBox username1;
        private MetroFramework.Controls.MetroTextBox password1;
        private MetroFramework.Controls.MetroButton signIn;
        private MetroFramework.Controls.MetroButton skipButton;
        private MetroFramework.Controls.MetroButton registerButton;
        private MetroFramework.Controls.MetroButton exitButton;
    }
}