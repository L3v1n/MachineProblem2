//PROGRAMMED BY: ORMIN CARIASO & ELVIN CERVANIA

namespace MachineProblem2
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPreDef = new System.Windows.Forms.Button();
            this.btnUserDef = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine Problem 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 660);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project by: Ormin Cariaso, Elvin Cervania and Felix Buna";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreDef
            // 
            this.btnPreDef.AutoSize = true;
            this.btnPreDef.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreDef.Location = new System.Drawing.Point(210, 310);
            this.btnPreDef.Name = "btnPreDef";
            this.btnPreDef.Size = new System.Drawing.Size(370, 40);
            this.btnPreDef.TabIndex = 2;
            this.btnPreDef.Text = "Bisection/Secant Method (Pre-defined function)";
            this.btnPreDef.UseVisualStyleBackColor = true;
            this.btnPreDef.Click += new System.EventHandler(this.btnPreDef_Click);
            // 
            // btnUserDef
            // 
            this.btnUserDef.AutoSize = true;
            this.btnUserDef.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDef.Location = new System.Drawing.Point(210, 375);
            this.btnUserDef.Name = "btnUserDef";
            this.btnUserDef.Size = new System.Drawing.Size(370, 40);
            this.btnUserDef.TabIndex = 3;
            this.btnUserDef.Text = "Bisection/Secant Method (User-defined function)";
            this.btnUserDef.UseVisualStyleBackColor = true;
            this.btnUserDef.Click += new System.EventHandler(this.btnUserDef_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bisection and Secant Method Calculator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(335, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 711);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUserDef);
            this.Controls.Add(this.btnPreDef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Analysis -  Machine Problem 2";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPreDef;
        private System.Windows.Forms.Button btnUserDef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}

