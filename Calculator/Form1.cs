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

      

        CalcFSM calc;
        public Form1()
        {
            InitializeComponent();
            // set this, otherwise key press won't fire
            this.KeyPreview = true;
            this.screen.Text = "0";
            calc = new CalcFSM(UpdateScreen);
        }

        private void UpdateScreen(string obj)
        {
            screen.Text = obj;
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
            }
        }

        private void num_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;            
            char digit = btn.Text[0];
            calc.process_event(CalcFSM.Events.Digit, digit);
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.Dot, null);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.Add, null);
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.Sub, null);
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.Mul, null);
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.Div, null);
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.Equals, null);
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.Percent, null);
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.Sqrt, null);
        }

        private void invBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.OneOverX, null);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.Clear, null);
        }

        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.ClearEntry, null);
        }

        private void changeSignBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.Sign, null);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.Del, null);
        }

        private void memClearBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.MemoryClear, null);
        }

        private void memRecallBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.MemoryRecall, null);
        }

        private void memStoreBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.MemoryStore, null);
        }

        private void memAddBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.MemoryAdd, null);
        }

        private void memSubBtn_Click(object sender, EventArgs e)
        {
            calc.process_event(CalcFSM.Events.MemorySub, null);
        }
    }
}
