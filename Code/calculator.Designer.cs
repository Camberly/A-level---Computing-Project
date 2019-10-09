namespace Algebraic_calculator_v0
{
    partial class calculator
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
            this.solve_equations_btn = new System.Windows.Forms.Button();
            this.table_val_btn = new System.Windows.Forms.Button();
            this.vector_btn = new System.Windows.Forms.Button();
            this.base_btn = new System.Windows.Forms.Button();
            this.enter_btn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CalcInput = new System.Windows.Forms.TextBox();
            this.logincheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // solve_equations_btn
            // 
            this.solve_equations_btn.Location = new System.Drawing.Point(40, 63);
            this.solve_equations_btn.Name = "solve_equations_btn";
            this.solve_equations_btn.Size = new System.Drawing.Size(120, 50);
            this.solve_equations_btn.TabIndex = 0;
            this.solve_equations_btn.Text = "Solve Equations";
            this.solve_equations_btn.UseVisualStyleBackColor = true;
            // 
            // table_val_btn
            // 
            this.table_val_btn.Location = new System.Drawing.Point(40, 137);
            this.table_val_btn.Name = "table_val_btn";
            this.table_val_btn.Size = new System.Drawing.Size(120, 50);
            this.table_val_btn.TabIndex = 1;
            this.table_val_btn.Text = "Table of Values";
            this.table_val_btn.UseVisualStyleBackColor = true;
            // 
            // vector_btn
            // 
            this.vector_btn.Location = new System.Drawing.Point(40, 213);
            this.vector_btn.Name = "vector_btn";
            this.vector_btn.Size = new System.Drawing.Size(120, 50);
            this.vector_btn.TabIndex = 2;
            this.vector_btn.Text = "Vectors";
            this.vector_btn.UseVisualStyleBackColor = true;
            // 
            // base_btn
            // 
            this.base_btn.Location = new System.Drawing.Point(40, 287);
            this.base_btn.Name = "base_btn";
            this.base_btn.Size = new System.Drawing.Size(120, 50);
            this.base_btn.TabIndex = 3;
            this.base_btn.Text = "Base-N";
            this.base_btn.UseVisualStyleBackColor = true;
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(829, 228);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(61, 20);
            this.enter_btn.TabIndex = 6;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(40, 453);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 50);
            this.back.TabIndex = 7;
            this.back.Text = "Main Menu";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(310, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 140);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CalcInput
            // 
            this.CalcInput.Location = new System.Drawing.Point(316, 234);
            this.CalcInput.Name = "CalcInput";
            this.CalcInput.Size = new System.Drawing.Size(491, 20);
            this.CalcInput.TabIndex = 10;
            // 
            // logincheck
            // 
            this.logincheck.AutoSize = true;
            this.logincheck.Location = new System.Drawing.Point(376, 332);
            this.logincheck.Name = "logincheck";
            this.logincheck.Size = new System.Drawing.Size(35, 13);
            this.logincheck.TabIndex = 11;
            this.logincheck.Text = "label1";
            // 
            // calculator
            // 
            this.AcceptButton = this.enter_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.logincheck);
            this.Controls.Add(this.CalcInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.base_btn);
            this.Controls.Add(this.vector_btn);
            this.Controls.Add(this.table_val_btn);
            this.Controls.Add(this.solve_equations_btn);
            this.Name = "calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solve_equations_btn;
        private System.Windows.Forms.Button table_val_btn;
        private System.Windows.Forms.Button vector_btn;
        private System.Windows.Forms.Button base_btn;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CalcInput;
        private System.Windows.Forms.Label logincheck;
    }
}