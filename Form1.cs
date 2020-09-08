using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal firstNumber = Convert.ToDecimal(txtNumber1.Text);
            decimal secondNumber = Convert.ToDecimal(txtNumber2.Text);
            decimal result = firstNumber + secondNumber;
            txtSolution.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            decimal firstNumber = Convert.ToDecimal(txtNumber1.Text);
            decimal secondNumber = Convert.ToDecimal(txtNumber2.Text);
            decimal result = firstNumber - secondNumber;
            txtSolution.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            decimal firstNumber = Convert.ToDecimal(txtNumber1.Text);
            decimal secondNumber = Convert.ToDecimal(txtNumber2.Text);
            decimal result = firstNumber * secondNumber;
            txtSolution.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal firstNumber = Convert.ToDecimal(txtNumber1.Text);
            decimal secondNumber = Convert.ToDecimal(txtNumber2.Text);
            decimal result = firstNumber / secondNumber;
            txtSolution.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSolution.Clear();
            txtNumber1.Clear();
            txtNumber2.Clear();
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtNumber1.Text);
            double secondNumber = Convert.ToDouble(txtNumber2.Text);
            double result = Math.Pow(firstNumber, secondNumber);
            txtSolution.Text = result.ToString();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {   
            decimal firstNumber = Convert.ToDecimal(txtNumber1.Text);
            decimal secondNumber = Convert.ToDecimal(txtNumber2.Text);
            decimal result = (firstNumber + secondNumber) / 2;
            txtSolution.Text = result.ToString();
        }
    }
}
