namespace Algebraic_calculator_v0
{
    partial class progress_tracker
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
           
            this.back = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            
            this.loginCheck1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
          
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(47, 467);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 50);
            this.back.TabIndex = 0;
            this.back.Text = "Main Menu";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(789, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 316);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "basic analysis";
            
            // 
            // loginCheck1
            // 
            this.loginCheck1.AutoSize = true;
            this.loginCheck1.Location = new System.Drawing.Point(47, 78);
            this.loginCheck1.Name = "loginCheck1";
            this.loginCheck1.Size = new System.Drawing.Size(35, 13);
            this.loginCheck1.TabIndex = 4;
            this.loginCheck1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progress_tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginCheck1);

            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.back);
            this.Name = "progress_tracker";
            this.Text = "Progress Tracker";
            this.Load += new System.EventHandler(this.progress_tracker_load);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox groupBox2;
       
        private System.Windows.Forms.Label loginCheck1;
        private System.Windows.Forms.Button button1;
    }
}