using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicMath;

namespace Calculator
{
    public partial class mainForm : Form
    {
        double total = 0;
        double totalFinal = 0;

        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        public mainForm()
        {
            InitializeComponent();
        }

        private void btOne_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btOne.Text;
        }

        private void btTwo_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btTwo.Text;
        }

        private void btThree_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btThree.Text;
        }

        private void btFour_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btFour.Text;
        }

        private void btFive_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btFive.Text;
        }

        private void btSix_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btSix.Text;
        }

        private void btSeven_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btSeven.Text;
        }

        private void btEight_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btEight.Text;
        }

        private void btNine_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btNine.Text;
        }

        private void btZero_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btZero.Text;
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += btDot.Text;
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked)
            {
                totalFinal = BasicMath.Arithmetic.Add(total, double.Parse(tbDisplay.Text));
            }
            else if (minusButtonClicked)
            {
                totalFinal = BasicMath.Arithmetic.Sub(total, double.Parse(tbDisplay.Text));
            }
            else if (divideButtonClicked)
            {
                totalFinal = BasicMath.Arithmetic.Div(total, double.Parse(tbDisplay.Text));
            }
            else if (multiplyButtonClicked)
            {
                totalFinal = BasicMath.Arithmetic.Mult(total, double.Parse(tbDisplay.Text));
            }

            tbDisplay.Text = totalFinal.ToString();
            total = 0;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            total += double.Parse(tbDisplay.Text);
            tbDisplay.Clear();

            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            total += double.Parse(tbDisplay.Text);
            tbDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = true;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btTimes_Click(object sender, EventArgs e)
        {
            total += double.Parse(tbDisplay.Text);
            tbDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            total += double.Parse(tbDisplay.Text);
            tbDisplay.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;
        }

        private void btSqrt_Click(object sender, EventArgs e)
        {
            totalFinal = BasicMath.Algebraic.Sqrt(double.Parse(tbDisplay.Text));
            tbDisplay.Text = totalFinal.ToString();
            total = 0;

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btCurt_Click(object sender, EventArgs e)
        {
            totalFinal = BasicMath.Algebraic.Curt(double.Parse(tbDisplay.Text));
            tbDisplay.Text = totalFinal.ToString();
            total = 0;

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btInv_Click(object sender, EventArgs e)
        {
            totalFinal = BasicMath.Algebraic.Inv(double.Parse(tbDisplay.Text));
            tbDisplay.Text = totalFinal.ToString();
            total = 0;

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btTan_Click(object sender, EventArgs e)
        {
            if (double.Parse(tbDisplay.Text) >= 90)
            {
                tbDisplay.Text = "Error";
            }
            else
            {
                totalFinal = BasicMath.Trigonometric.Tan(double.Parse(tbDisplay.Text));
                tbDisplay.Text = totalFinal.ToString();
            }

            total = 0;

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btSin_Click(object sender, EventArgs e)
        {
            totalFinal = BasicMath.Trigonometric.Sin(double.Parse(tbDisplay.Text));
            tbDisplay.Text = totalFinal.ToString();
            total = 0;

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btCos_Click(object sender, EventArgs e)
        {
            totalFinal = BasicMath.Trigonometric.Cos(double.Parse(tbDisplay.Text));
            tbDisplay.Text = totalFinal.ToString();
            total = 0;

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }
    }
}
