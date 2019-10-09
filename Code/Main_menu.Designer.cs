namespace Algebraic_calculator_v0
{
    partial class Main_menu
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
            this.calc_main_menu = new System.Windows.Forms.Button();
            this.cheat_sheets_main_menu = new System.Windows.Forms.Button();
            this.questions_main_menu = new System.Windows.Forms.Button();
            this.progress_tracker_main_menu = new System.Windows.Forms.Button();
            this.exit_software = new System.Windows.Forms.Button();
            this.loginCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calc_main_menu
            // 
            this.calc_main_menu.Location = new System.Drawing.Point(400, 94);
            this.calc_main_menu.Name = "calc_main_menu";
            this.calc_main_menu.Size = new System.Drawing.Size(200, 60);
            this.calc_main_menu.TabIndex = 0;
            this.calc_main_menu.Text = "Calculator";
            this.calc_main_menu.UseVisualStyleBackColor = true;
            this.calc_main_menu.Click += new System.EventHandler(this.calc_main_menu_Click);
            // 
            // cheat_sheets_main_menu
            // 
            this.cheat_sheets_main_menu.Location = new System.Drawing.Point(400, 179);
            this.cheat_sheets_main_menu.Name = "cheat_sheets_main_menu";
            this.cheat_sheets_main_menu.Size = new System.Drawing.Size(200, 60);
            this.cheat_sheets_main_menu.TabIndex = 1;
            this.cheat_sheets_main_menu.Text = "Cheat Sheets";
            this.cheat_sheets_main_menu.UseVisualStyleBackColor = true;
            this.cheat_sheets_main_menu.Click += new System.EventHandler(this.cheat_sheets_main_menu_Click);
            // 
            // questions_main_menu
            // 
            this.questions_main_menu.Location = new System.Drawing.Point(400, 264);
            this.questions_main_menu.Name = "questions_main_menu";
            this.questions_main_menu.Size = new System.Drawing.Size(200, 60);
            this.questions_main_menu.TabIndex = 2;
            this.questions_main_menu.Text = "Questions";
            this.questions_main_menu.UseVisualStyleBackColor = true;
            this.questions_main_menu.Click += new System.EventHandler(this.questions_main_menu_Click);
            // 
            // progress_tracker_main_menu
            // 
            this.progress_tracker_main_menu.Location = new System.Drawing.Point(400, 349);
            this.progress_tracker_main_menu.Name = "progress_tracker_main_menu";
            this.progress_tracker_main_menu.Size = new System.Drawing.Size(200, 60);
            this.progress_tracker_main_menu.TabIndex = 3;
            this.progress_tracker_main_menu.Text = "Progress Tracker";
            this.progress_tracker_main_menu.UseVisualStyleBackColor = true;
            this.progress_tracker_main_menu.Click += new System.EventHandler(this.progress_tracker_main_menu_Click);
            // 
            // exit_software
            // 
            this.exit_software.Location = new System.Drawing.Point(400, 434);
            this.exit_software.Name = "exit_software";
            this.exit_software.Size = new System.Drawing.Size(200, 60);
            this.exit_software.TabIndex = 4;
            this.exit_software.Text = "Exit Software";
            this.exit_software.UseVisualStyleBackColor = true;
            this.exit_software.Click += new System.EventHandler(this.exit_software_Click);
            // 
            // loginCheck
            // 
            this.loginCheck.AutoSize = true;
            this.loginCheck.Location = new System.Drawing.Point(94, 94);
            this.loginCheck.Name = "loginCheck";
            this.loginCheck.Size = new System.Drawing.Size(35, 13);
            this.loginCheck.TabIndex = 5;
            this.loginCheck.Text = "label1";
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.loginCheck);
            this.Controls.Add(this.exit_software);
            this.Controls.Add(this.progress_tracker_main_menu);
            this.Controls.Add(this.questions_main_menu);
            this.Controls.Add(this.cheat_sheets_main_menu);
            this.Controls.Add(this.calc_main_menu);
            this.Name = "Main_menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Main_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc_main_menu;
        private System.Windows.Forms.Button cheat_sheets_main_menu;
        private System.Windows.Forms.Button questions_main_menu;
        private System.Windows.Forms.Button progress_tracker_main_menu;
        private System.Windows.Forms.Button exit_software;
        public System.Windows.Forms.Label loginCheck;
    }
}

