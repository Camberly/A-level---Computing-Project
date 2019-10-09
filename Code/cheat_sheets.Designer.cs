namespace Algebraic_calculator_v0
{
    partial class cheat_sheets
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
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.basicAlgebra = new MetroFramework.Controls.MetroTabPage();
            this.coordinateGeometry = new MetroFramework.Controls.MetroTabPage();
            this.algebraicMethods = new MetroFramework.Controls.MetroTabPage();
            this.binomialExpansion = new MetroFramework.Controls.MetroTabPage();
            this.trigonometry = new MetroFramework.Controls.MetroTabPage();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 470);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 50);
            this.back.TabIndex = 0;
            this.back.Text = "Main Menu";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.basicAlgebra);
            this.TabControl.Controls.Add(this.coordinateGeometry);
            this.TabControl.Controls.Add(this.algebraicMethods);
            this.TabControl.Controls.Add(this.binomialExpansion);
            this.TabControl.Controls.Add(this.trigonometry);
            this.TabControl.Location = new System.Drawing.Point(81, 83);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(774, 320);
            this.TabControl.TabIndex = 1;
            this.TabControl.UseSelectable = true;
            // 
            // basicAlgebra
            // 
            this.basicAlgebra.HorizontalScrollbarBarColor = true;
            this.basicAlgebra.HorizontalScrollbarHighlightOnWheel = false;
            this.basicAlgebra.HorizontalScrollbarSize = 10;
            this.basicAlgebra.Location = new System.Drawing.Point(4, 38);
            this.basicAlgebra.Name = "basicAlgebra";
            this.basicAlgebra.Size = new System.Drawing.Size(766, 278);
            this.basicAlgebra.TabIndex = 0;
            this.basicAlgebra.Text = "Basic Algebra";
            this.basicAlgebra.VerticalScrollbarBarColor = true;
            this.basicAlgebra.VerticalScrollbarHighlightOnWheel = false;
            this.basicAlgebra.VerticalScrollbarSize = 10;
            // 
            // coordinateGeometry
            // 
            this.coordinateGeometry.HorizontalScrollbarBarColor = true;
            this.coordinateGeometry.HorizontalScrollbarHighlightOnWheel = false;
            this.coordinateGeometry.HorizontalScrollbarSize = 10;
            this.coordinateGeometry.Location = new System.Drawing.Point(4, 38);
            this.coordinateGeometry.Name = "coordinateGeometry";
            this.coordinateGeometry.Size = new System.Drawing.Size(615, 261);
            this.coordinateGeometry.TabIndex = 1;
            this.coordinateGeometry.Text = "Coordinate Geometry";
            this.coordinateGeometry.VerticalScrollbarBarColor = true;
            this.coordinateGeometry.VerticalScrollbarHighlightOnWheel = false;
            this.coordinateGeometry.VerticalScrollbarSize = 10;
            // 
            // Algebraic Methods
            // 
            this.algebraicMethods.HorizontalScrollbarBarColor = true;
            this.algebraicMethods.HorizontalScrollbarHighlightOnWheel = false;
            this.algebraicMethods.HorizontalScrollbarSize = 10;
            this.algebraicMethods.Location = new System.Drawing.Point(4, 38);
            this.algebraicMethods.Name = "Algebraic Methods";
            this.algebraicMethods.Size = new System.Drawing.Size(615, 261);
            this.algebraicMethods.TabIndex = 2;
            this.algebraicMethods.Text = "Algebraic Methods";
            this.algebraicMethods.VerticalScrollbarBarColor = true;
            this.algebraicMethods.VerticalScrollbarHighlightOnWheel = false;
            this.algebraicMethods.VerticalScrollbarSize = 10;
            // 
            // Binomial Expansion
            // 
            this.binomialExpansion.HorizontalScrollbarBarColor = true;
            this.binomialExpansion.HorizontalScrollbarHighlightOnWheel = false;
            this.binomialExpansion.HorizontalScrollbarSize = 10;
            this.binomialExpansion.Location = new System.Drawing.Point(4, 38);
            this.binomialExpansion.Name = "Binomial Expansion";
            this.binomialExpansion.Size = new System.Drawing.Size(615, 261);
            this.binomialExpansion.TabIndex = 3;
            this.binomialExpansion.Text = "Binomial Expansion";
            this.binomialExpansion.VerticalScrollbarBarColor = true;
            this.binomialExpansion.VerticalScrollbarHighlightOnWheel = false;
            this.binomialExpansion.VerticalScrollbarSize = 10;
            // 
            // trigonometry
            // 
            this.trigonometry.HorizontalScrollbarBarColor = true;
            this.trigonometry.HorizontalScrollbarHighlightOnWheel = false;
            this.trigonometry.HorizontalScrollbarSize = 10;
            this.trigonometry.Location = new System.Drawing.Point(4, 38);
            this.trigonometry.Name = "trigonometry";
            this.trigonometry.Size = new System.Drawing.Size(615, 261);
            this.trigonometry.TabIndex = 4;
            this.trigonometry.Text = "Trigonometry";
            this.trigonometry.VerticalScrollbarBarColor = true;
            this.trigonometry.VerticalScrollbarHighlightOnWheel = false;
            this.trigonometry.VerticalScrollbarSize = 10;
            // 
            // cheat_sheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.back);
            this.Name = "cheat_sheets";
            this.Text = "Cheat Sheets";
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage basicAlgebra;
        private MetroFramework.Controls.MetroTabPage coordinateGeometry;
        private MetroFramework.Controls.MetroTabPage algebraicMethods;
        private MetroFramework.Controls.MetroTabPage binomialExpansion;
        private MetroFramework.Controls.MetroTabPage trigonometry;
    }
}