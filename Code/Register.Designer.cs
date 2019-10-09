namespace Algebraic_calculator_v0
{
    partial class Register
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
            this.registerWrite = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.emailAddress = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.usernameRegister = new System.Windows.Forms.TextBox();
            this.passwordRegister = new System.Windows.Forms.TextBox();
            this.passwordRepeat = new System.Windows.Forms.TextBox();
            this.emailRegister = new System.Windows.Forms.TextBox();
            this.firstNameReg = new System.Windows.Forms.TextBox();
            this.secondNameReg = new System.Windows.Forms.TextBox();
            this.repeatLabel = new MetroFramework.Controls.MetroLabel();
            this.loginScreen = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // registerWrite
            // 
            this.registerWrite.Enabled = false;
            this.registerWrite.Highlight = true;
            this.registerWrite.Location = new System.Drawing.Point(277, 304);
            this.registerWrite.Name = "registerWrite";
            this.registerWrite.Size = new System.Drawing.Size(92, 28);
            this.registerWrite.TabIndex = 0;
            this.registerWrite.Text = "Register";
            this.registerWrite.UseSelectable = true;
            this.registerWrite.Click += new System.EventHandler(this.registerWrite_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(40, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Username";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Password";
            // 
            // emailAddress
            // 
            this.emailAddress.AutoSize = true;
            this.emailAddress.Location = new System.Drawing.Point(25, 197);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(92, 19);
            this.emailAddress.TabIndex = 8;
            this.emailAddress.Text = "Email Address";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(296, 72);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "First Name";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(296, 116);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Second Name";
            // 
            // usernameRegister
            // 
            this.usernameRegister.Location = new System.Drawing.Point(123, 71);
            this.usernameRegister.Name = "usernameRegister";
            this.usernameRegister.Size = new System.Drawing.Size(159, 20);
            this.usernameRegister.TabIndex = 13;
            // 
            // passwordRegister
            // 
            this.passwordRegister.Location = new System.Drawing.Point(123, 115);
            this.passwordRegister.Name = "passwordRegister";
            this.passwordRegister.Size = new System.Drawing.Size(159, 20);
            this.passwordRegister.TabIndex = 14;
            // 
            // passwordRepeat
            // 
            this.passwordRepeat.Location = new System.Drawing.Point(123, 153);
            this.passwordRepeat.Name = "passwordRepeat";
            this.passwordRepeat.Size = new System.Drawing.Size(159, 20);
            this.passwordRepeat.TabIndex = 15;
            // 
            // emailRegister
            // 
            this.emailRegister.Location = new System.Drawing.Point(123, 197);
            this.emailRegister.Name = "emailRegister";
            this.emailRegister.Size = new System.Drawing.Size(159, 20);
            this.emailRegister.TabIndex = 16;
            // 
            // firstNameReg
            // 
            this.firstNameReg.Location = new System.Drawing.Point(395, 71);
            this.firstNameReg.Name = "firstNameReg";
            this.firstNameReg.Size = new System.Drawing.Size(159, 20);
            this.firstNameReg.TabIndex = 17;
            // 
            // secondNameReg
            // 
            this.secondNameReg.Location = new System.Drawing.Point(395, 116);
            this.secondNameReg.Name = "secondNameReg";
            this.secondNameReg.Size = new System.Drawing.Size(159, 20);
            this.secondNameReg.TabIndex = 18;
            // 
            // repeatLabel
            // 
            this.repeatLabel.AutoSize = true;
            this.repeatLabel.Location = new System.Drawing.Point(9, 153);
            this.repeatLabel.Name = "repeatLabel";
            this.repeatLabel.Size = new System.Drawing.Size(108, 19);
            this.repeatLabel.TabIndex = 19;
            this.repeatLabel.Text = "Repeat Password";
            // 
            // loginScreen
            // 
            this.loginScreen.Highlight = true;
            this.loginScreen.Location = new System.Drawing.Point(148, 304);
            this.loginScreen.Name = "loginScreen";
            this.loginScreen.Size = new System.Drawing.Size(95, 28);
            this.loginScreen.TabIndex = 20;
            this.loginScreen.Text = "Back to Login";
            this.loginScreen.UseSelectable = true;
            this.loginScreen.Click += new System.EventHandler(this.loginScreen_Click);
            // 
            // Register
            // 
            this.AcceptButton = this.registerWrite;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 355);
            this.Controls.Add(this.loginScreen);
            this.Controls.Add(this.repeatLabel);
            this.Controls.Add(this.secondNameReg);
            this.Controls.Add(this.firstNameReg);
            this.Controls.Add(this.emailRegister);
            this.Controls.Add(this.passwordRepeat);
            this.Controls.Add(this.passwordRegister);
            this.Controls.Add(this.usernameRegister);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.registerWrite);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton registerWrite;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel emailAddress;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox usernameRegister;
        private System.Windows.Forms.TextBox passwordRegister;
        private System.Windows.Forms.TextBox passwordRepeat;
        private System.Windows.Forms.TextBox emailRegister;
        private System.Windows.Forms.TextBox firstNameReg;
        private System.Windows.Forms.TextBox secondNameReg;
        private MetroFramework.Controls.MetroLabel repeatLabel;
        private MetroFramework.Controls.MetroButton loginScreen;
    }
}