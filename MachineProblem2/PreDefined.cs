//PROGRAMMED BY: ORMIN CARIASO & ELVIN CERVANIA

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Symbolics;
using FParsec;

namespace MachineProblem2
{
    public partial class PreDefined : Form
    {
        public PreDefined()
        {
            InitializeComponent();
        }
        private void PreDefined_Load(object sender, EventArgs e)
        {
            ActiveControl = txtValA;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Home f1 = new Home();
            f1.Show();
            this.Hide();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (rbBisection.Checked == false & rbSecant.Checked == false)
            {
                MessageBox.Show("Choose a mathematical method", "No method chosen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }            
            if (txtValA.Text == string.Empty | txtValB.Text == string.Empty | txtValE.Text == string.Empty | txtValN.Text == string.Empty)
            {
                MessageBox.Show("Enter values", "No values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbBisection.Checked)
            {
                dgvResult.Columns.Add("columnN", "n");
                dgvResult.Columns.Add("coulumnA", "a");
                dgvResult.Columns.Add("coulumnB", "b");
                dgvResult.Columns.Add("coulumnC", "c");
                dgvResult.Columns.Add("coulumnAB", "|a-b|");
                dgvResult.Columns.Add("coulumnE", "<e");
                dgvResult.Columns.Add("coulumnFc", "f(c)");                
                label7.Enabled = true;
                label8.Enabled = true;
                label9.Enabled = true;
                label10.Enabled = true;
                label11.Enabled = true;
                txtFa.Enabled = true;
                txtFb.Enabled = true;
                txtCn.Enabled = true;
                txtFCn.Enabled = true;

                double valA, valB, valC, valE;
                int valN;

                valA = double.Parse(txtValA.Text);
                valB = double.Parse(txtValB.Text);
                valE = double.Parse(txtValE.Text);
                valN = int.Parse(txtValN.Text);
                txtFa.Text = "" + func(valA);
                txtFb.Text = "" + func(valB);    
                              
                for (int i = 1; i <= valN; i++)
                {
                    valC = (valA + valB) / 2;
                    dgvResult.Rows.Add(i, valA, valB, valC, Math.Abs(valB - valA), Math.Abs(valB - valA) < valE ? "Yes" : "No", func(valC));
                    if (Math.Abs(valB - valA) < valE)
                    {
                        break;
                    }
                    if (func(valC) == 0)
                    {
                        break;
                    }
                    if (func(valA) * func(valC) < 0)
                    {
                        valB = valC;
                    }
                    else
                    {
                        valA = valC;
                    }
                }
                txtCn.Text = "" + ((valA + valB) / 2);
                txtFCn.Text = "" + (func((valA + valB) / 2));
            }
            if (rbSecant.Checked)
            {
                dgvResult.Columns.Add("columnN", "n");
                dgvResult.Columns.Add("coulumnA", "xi-1");
                dgvResult.Columns.Add("coulumnB", "xi");
                dgvResult.Columns.Add("coulumnC", "f(xi-1)");
                dgvResult.Columns.Add("coulumnAB", "f(xi)");
                dgvResult.Columns.Add("coulumnE", "xi+1");
                dgvResult.Columns.Add("coulumnFc", "|xi+1 - xi|");
                dgvResult.Columns.Add("coulumnFc", "<e");
                label9.Enabled = true;
                label10.Enabled = true;
                label11.Enabled = true;
                txtCn.Enabled = true;
                txtFCn.Enabled = true;

                double valX0, valX1, valE, xi, fi, xiPrev, fiPrev, xiNext, absDiff;
                int valN, i = 1;

                valX0 = double.Parse(txtValA.Text);
                valX1 = double.Parse(txtValB.Text);
                valE = double.Parse(txtValE.Text);
                valN = int.Parse(txtValN.Text); 

                xiPrev = valX0; xi = valX1;
                fiPrev = func(xiPrev); fi = func(xi);;
                do
                {
                    xiNext = xi - fi * (xi - xiPrev) / (fi - fiPrev);
                    absDiff = Math.Abs(xiNext - xi);

                    dgvResult.Rows.Add(i, xiPrev, xi, fiPrev, fi, xiNext, absDiff, absDiff < valE ? "Yes" : "No");

                    if (absDiff < valE)
                    {
                        break;
                    }

                    i++;
                    xiPrev = xi;
                    xi = xiNext;
                    fiPrev = fi;
                    fi = func(xi);

                } while (absDiff >= valE && i <= valN);
                txtCn.Text = "" + xi;
                txtFCn.Text = "" + fi;
            }
            txtFunction.Enabled = false;
            txtValA.Enabled = false;
            txtValB.Enabled = false;
            txtValE.Enabled = false;
            txtValN.Enabled = false;
            gbFunction.Enabled = false;
            btnCalc.Enabled = false;
        }
        static double func(double x)
        {
            return 1 / (1 - x);
        }
        private void rbBisection_CheckedChanged(object sender, EventArgs e)
        {
            txtValA.Enabled = true;
            txtValB.Enabled = true;
            txtValE.Enabled = true;
            txtValN.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Visible = true;
            label8.Visible = true;
            txtFa.Visible = true;
            txtFb.Visible = true;
            txtValA.Focus();
            label3.Text = "Enter value for a";
            label4.Text = "Enter value for b";
            label5.Text = "Enter value for e";
            label6.Text = "Enter n of iterations";
        }
        private void rbSecant_CheckedChanged(object sender, EventArgs e)
        {
            txtValA.Enabled = true;
            txtValB.Enabled = true;
            txtValE.Enabled = true;
            txtValN.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Visible = false;
            label8.Visible = false;
            txtFa.Visible = false;
            txtFb.Visible = false;
            txtValA.Focus();
            label3.Text = "Enter value for x0";
            label4.Text = "Enter value for x1";
            label5.Text = "Enter value for e";
            label6.Text = "Enter n of iterations";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label8.Visible = true;
            txtFa.Visible = true;
            txtFb.Visible = true;
            txtValA.Clear();
            txtValB.Clear();
            txtValE.Clear();
            txtValN.Clear();
            txtFa.Text = string.Empty;
            txtFb.Text = string.Empty;
            txtCn.Text = string.Empty;
            txtFCn.Text = string.Empty;         
            rbBisection.Checked = false;
            rbSecant.Checked = false;            
            txtFunction.Enabled = true;
            txtValA.Enabled = false;
            txtValB.Enabled = false;
            txtValE.Enabled = false;
            txtValN.Enabled = false;
            label3.Enabled = false;
            label3.Text = "Enter value for";
            label4.Enabled = false;
            label4.Text = "Enter value for";            
            label7.Visible = true;
            label8.Visible = true;
            txtFa.Visible = true;
            txtFb.Visible = true;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            txtFa.Enabled = false;
            txtFb.Enabled = false;
            txtCn.Enabled = false;
            txtFCn.Enabled = false;
            gbFunction.Enabled = true;
            btnCalc.Enabled = true;          
            dgvResult.Rows.Clear();
            dgvResult.Columns.Clear();
        }
    }
}
