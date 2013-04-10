using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool dirty = false;
        private bool dotPressed = false;
        private bool negative = false;
        private string reg0 = String.Empty;
        private string reg1 = String.Empty;
        private string reg2 = String.Empty;

        private DataTable dataTable = new DataTable();

        enum Operation
        {
            None,
            Add,
            Sub,
            Div,
            Mul
        };

        Operation op = Operation.None;

        public Form1()
        {
            InitializeComponent();
            // set this, otherwise key press won't fire
            this.KeyPreview = true;
            UpdateScreen();
            DataTable dt = new DataTable();
            double v = double.Parse(dt.Compute("-5.44", "").ToString());
            v = double.Parse(dt.Compute("-5.44 + 10.10", "").ToString());
            v = double.Parse(dt.Compute("+3", "").ToString());
            v = double.Parse(dt.Compute("10/3.0", "").ToString());
            v = double.Parse(dt.Compute("10.0/3", "").ToString());

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button btn = null;
            char c = e.KeyChar;
            switch (c)
            {
                case '0':
                    btn = num0;
                    break;
                case '1':
                    btn = num1;
                    break;
                case '2':
                    btn = num2;
                    break;
                case '3':
                    btn = num3;
                    break;
                case '4':
                    btn = num4;
                    break;
                case '5':
                    btn = num5;
                    break;
                case '6':
                    btn = num6;
                    break;
                case '7':
                    btn = num7;
                    break;
                case '8':
                    btn = num8;
                    break;
                case '9':
                    btn = num9;
                    break;
                case '.':
                    dotBtn.PerformClick();
                    return;
                case '-':
                    subBtn.PerformClick();
                    return;
                case '+':
                    addBtn.PerformClick();
                    return;
                case '/':
                    divBtn.PerformClick();
                    return;
                case '*':
                    mulBtn.PerformClick();
                    return;
                case '=':
                    equalBtn.PerformClick();
                    return;
                case (char)13: //enter key
                    equalBtn.PerformClick();
                    return;
            }

            if (btn != null)
            {
                btn.PerformClick();
                if (!string.IsNullOrEmpty(reg0))
                    dirty = true;
            }
        }

        private void num_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                int val = int.Parse(btn.Text);

                string repr = reg0;
                if (dotPressed)
                {
                    repr += '.';
                    dotPressed = false;
                }
                repr += val.ToString();
                double tmp = double.Parse(repr);
                if (tmp > 0.0 && negative == true)
                {
                    tmp *= -1.0;
                }
                reg0 = tmp.ToString();
                UpdateScreen();
            }
            catch (Exception)
            {
            }
        }

        private void UpdateScreen()
        {
            if (string.IsNullOrEmpty(reg0))
            {
                screen.Text = "0";
            }
            else
            {
                screen.Text = reg0;
            }
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (!screen.Text.Contains('.'))
                dotPressed = true;
        }

        private void Compute()
        {
            if (string.IsNullOrEmpty(reg0))
                return;

            if (!string.IsNullOrEmpty(reg1))
            {
                string op_repr = string.Empty;
                switch (op)
                {
                    case Operation.Add:
                        op_repr = "+";
                        break;
                    case Operation.Sub:
                        op_repr = "-";
                        break;
                    case Operation.Div:
                        op_repr = "/";
                        break;
                    case Operation.Mul:
                        op_repr = "*";
                        break;
                }
                string expr = reg1 + op_repr + reg0;
                reg1 = dataTable.Compute(expr, "").ToString();
                reg0 = string.Empty;
            }
            else
            {
                reg1 = reg0;
                reg0 = string.Empty;
            }

            dirty = false;
            negative = false;
            screen.Text = reg1;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            op = Operation.Add;
            Compute();
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (!dirty)
            {
                negative = true;
            }
            else
            {
                op = Operation.Sub;
                Compute();
            }
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            op = Operation.Mul;
            Compute();
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            op = Operation.Div;
            Compute();
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            Compute();
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {

        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(reg0))
                return;
            double val = double.Parse(reg0);
            val = Math.Sqrt(val);
            reg0 = val.ToString();
            screen.Text = reg0;
        }
    }
}
