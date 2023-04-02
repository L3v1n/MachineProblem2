//PROGRAMMED BY: ORMIN CARIASO & ELVIN CERVANIA

namespace MachineProblem2
{
    partial class PreDefined
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbBisection = new System.Windows.Forms.RadioButton();
            this.rbSecant = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbFunction = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.txtFa = new System.Windows.Forms.TextBox();
            this.txtFb = new System.Windows.Forms.TextBox();
            this.txtCn = new System.Windows.Forms.TextBox();
            this.txtFCn = new System.Windows.Forms.TextBox();
            this.gbFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter a funcion f(x)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFunction
            // 
            this.txtFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFunction.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFunction.Location = new System.Drawing.Point(55, 75);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.ReadOnly = true;
            this.txtFunction.Size = new System.Drawing.Size(300, 25);
            this.txtFunction.TabIndex = 1;
            this.txtFunction.TabStop = false;
            this.txtFunction.Text = "1/1-x";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bisection/Secant Method (Pre-defined function)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbBisection
            // 
            this.rbBisection.AutoSize = true;
            this.rbBisection.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBisection.Location = new System.Drawing.Point(6, 28);
            this.rbBisection.Name = "rbBisection";
            this.rbBisection.Size = new System.Drawing.Size(137, 21);
            this.rbBisection.TabIndex = 12;
            this.rbBisection.TabStop = true;
            this.rbBisection.Text = "Bisection Method";
            this.rbBisection.UseVisualStyleBackColor = true;
            this.rbBisection.CheckedChanged += new System.EventHandler(this.rbBisection_CheckedChanged);
            // 
            // rbSecant
            // 
            this.rbSecant.AutoSize = true;
            this.rbSecant.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSecant.Location = new System.Drawing.Point(176, 28);
            this.rbSecant.Name = "rbSecant";
            this.rbSecant.Size = new System.Drawing.Size(123, 21);
            this.rbSecant.TabIndex = 13;
            this.rbSecant.TabStop = true;
            this.rbSecant.Text = "Secant Method";
            this.rbSecant.UseVisualStyleBackColor = true;
            this.rbSecant.CheckedChanged += new System.EventHandler(this.rbSecant_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter value for";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValB
            // 
            this.txtValB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValB.Enabled = false;
            this.txtValB.Location = new System.Drawing.Point(235, 140);
            this.txtValB.Name = "txtValB";
            this.txtValB.Size = new System.Drawing.Size(120, 22);
            this.txtValB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter value for";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValA
            // 
            this.txtValA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValA.Enabled = false;
            this.txtValA.Location = new System.Drawing.Point(55, 140);
            this.txtValA.Name = "txtValA";
            this.txtValA.Size = new System.Drawing.Size(120, 22);
            this.txtValA.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter value for e";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValE
            // 
            this.txtValE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValE.Enabled = false;
            this.txtValE.Location = new System.Drawing.Point(425, 140);
            this.txtValE.Name = "txtValE";
            this.txtValE.Size = new System.Drawing.Size(120, 22);
            this.txtValE.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(610, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter n of iterations";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValN
            // 
            this.txtValN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValN.Enabled = false;
            this.txtValN.Location = new System.Drawing.Point(610, 140);
            this.txtValN.Name = "txtValN";
            this.txtValN.Size = new System.Drawing.Size(120, 22);
            this.txtValN.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "f(a) =";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "f(b) =";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(610, 645);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.AutoSize = true;
            this.btnCalc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(330, 200);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(120, 40);
            this.btnCalc.TabIndex = 14;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 605);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "f(Cn) =";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 575);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cn =";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Solution:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(55, 645);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbFunction
            // 
            this.gbFunction.BackColor = System.Drawing.Color.Transparent;
            this.gbFunction.Controls.Add(this.rbBisection);
            this.gbFunction.Controls.Add(this.rbSecant);
            this.gbFunction.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFunction.Location = new System.Drawing.Point(425, 73);
            this.gbFunction.Name = "gbFunction";
            this.gbFunction.Size = new System.Drawing.Size(305, 61);
            this.gbFunction.TabIndex = 11;
            this.gbFunction.TabStop = false;
            this.gbFunction.Text = "Choose mathematical  method";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResult.Location = new System.Drawing.Point(40, 320);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersWidth = 20;
            this.dgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(703, 220);
            this.dgvResult.TabIndex = 19;
            this.dgvResult.TabStop = false;
            // 
            // txtFa
            // 
            this.txtFa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFa.Enabled = false;
            this.txtFa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFa.Location = new System.Drawing.Point(100, 248);
            this.txtFa.Name = "txtFa";
            this.txtFa.ReadOnly = true;
            this.txtFa.Size = new System.Drawing.Size(270, 25);
            this.txtFa.TabIndex = 16;
            this.txtFa.TabStop = false;
            // 
            // txtFb
            // 
            this.txtFb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFb.Enabled = false;
            this.txtFb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFb.Location = new System.Drawing.Point(100, 278);
            this.txtFb.Name = "txtFb";
            this.txtFb.ReadOnly = true;
            this.txtFb.Size = new System.Drawing.Size(270, 25);
            this.txtFb.TabIndex = 18;
            this.txtFb.TabStop = false;
            // 
            // txtCn
            // 
            this.txtCn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCn.Enabled = false;
            this.txtCn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCn.Location = new System.Drawing.Point(95, 573);
            this.txtCn.Name = "txtCn";
            this.txtCn.ReadOnly = true;
            this.txtCn.Size = new System.Drawing.Size(270, 25);
            this.txtCn.TabIndex = 22;
            this.txtCn.TabStop = false;
            // 
            // txtFCn
            // 
            this.txtFCn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFCn.Enabled = false;
            this.txtFCn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFCn.Location = new System.Drawing.Point(110, 603);
            this.txtFCn.Name = "txtFCn";
            this.txtFCn.ReadOnly = true;
            this.txtFCn.Size = new System.Drawing.Size(270, 25);
            this.txtFCn.TabIndex = 24;
            this.txtFCn.TabStop = false;
            // 
            // PreDefined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 711);
            this.Controls.Add(this.txtFCn);
            this.Controls.Add(this.txtCn);
            this.Controls.Add(this.txtFb);
            this.Controls.Add(this.txtFa);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.gbFunction);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "PreDefined";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Analysis -  Machine Problem 2";
            this.Load += new System.EventHandler(this.PreDefined_Load);
            this.gbFunction.ResumeLayout(false);
            this.gbFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBisection;
        private System.Windows.Forms.RadioButton rbSecant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.TextBox txtFa;
        private System.Windows.Forms.TextBox txtFb;
        private System.Windows.Forms.TextBox txtCn;
        private System.Windows.Forms.TextBox txtFCn;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}