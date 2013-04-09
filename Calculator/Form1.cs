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
        private bool dotPressed;
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
            }

            if (btn != null)
                btn.PerformClick();

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
    }
}
