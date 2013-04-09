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
        private double reg0 = 0.0;
        private double reg1 = 0.0;
        private double reg2 = 0.0;

        public Form1()
        {
            InitializeComponent();
            // set this, otherwise key press won't fire
            this.KeyPreview = true;
            UpdateScreen();
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
                    btn = dotBtn;
                    break;
                case '-':
                    btn = subBtn;
                    break;
                case '+':
                    btn = addBtn; 
                    break;
                case '/':
                    btn = divBtn;
                    break;
                case '*':
                    btn = mulBtn;
                    break;
                case '=':
                case (char)13: //enter key
                    btn = equalBtn;
                    break;
            }

            if (btn != null)
            {                
                btn.PerformClick();
                if (reg0 != 0.0)
                    dirty = true;
            }
        }

        private void num_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int val = int.Parse(btn.Text);

            string repr = screen.Text;
            if (dotPressed)
            {
                repr += '.';
                dotPressed = false;
            }
            repr += val.ToString();
            reg0 = double.Parse(repr);
            if (reg0 > 0.0 && negative == true)
            {
                reg0 *= -1.0;
            }
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            screen.Text = reg0.ToString();
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (!screen.Text.Contains('.'))
                dotPressed = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (!dirty)
            {
                negative = true;
            }
            else
            {

            }
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {

        }

        private void divBtn_Click(object sender, EventArgs e)
        {

        }

        private void equalBtn_Click(object sender, EventArgs e)
        {

        }

        private void percentBtn_Click(object sender, EventArgs e)
        {

        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
