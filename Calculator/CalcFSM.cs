using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcFSM
    {

        enum States
        {
            Init = 0,
            Accumulate = 1,
            AccumulateDot = 2,
            Compute = 3
        };

        public enum Events
        {
            Digit = 0,
            Dot = 1,
            Add = 2,
            Sub = 3,
            Mul = 4,
            Div = 5,
            Sqrt = 6,
            Percent = 7,
            OneOverX = 8,
            Sign = 9,
            Equals = 10,
            Del = 11,
            ClearEntry = 12,
            Clear = 13,
            MemoryClear = 14,
            MemoryRecall = 15,
            MemoryStore = 16,
            MemoryAdd = 17,
            MemorySub = 18
        }

        enum Op
        {
            NoOp = 0,
            Add = 1,
            Sub = 2,
            Mul = 3,
            Div = 4,
            Sqrt
        };

        double Memory = 0;
        double Result = 0;
        string Screen;
        Op pending_op = Op.NoOp;
        States state = States.Init;
        Action<object>[,] fsm;
        Action<string> update_screen_action;
        private bool negative;

        public CalcFSM(Action<string> update_screen)
        {
            fsm = new Action<object>[,]{
                //  Digit   Dot     Add     Sub     Mul     Div     Sqrt    Percent     OneOverX    Sign    Equals  Del     ClearEntry  Clear   MemoryClear MemoryRecall    MemoryStore     MemoryAdd   MemorySub
                    {digit, dot,    add,    sub,    mul,    div,    sqrt,   percent,    reciproc,   null,   equal,  null,   clearEntry, clear,  null,       null,           null          , null      , null}, // Init
                    {digit, dot,    add,    sub,    mul,    div,    sqrt,   percent,    reciproc,   sign,   equal,  del,    clearEntry, clear,  null,       null,           null          , null      , null}, // Accumulate
                    {digit, null,   add,    sub,    mul,    div,    sqrt,   percent,    reciproc,   sign,   equal,  del,    clearEntry, clear,  null,       null,           null          , null      , null}, // AccumulateDot
                    {null,  null,   null,   null,   null,   null,   null,   null,       null,       null,   null,   null,   clearEntry, clear,  null,       null,           null          , null      , null} // Compute
                };

            update_screen_action = update_screen;
        }

        private void clear(object arg)
        {
            state = States.Init;
            Screen = string.Empty;
            negative = false;
            Result = 0;
            Memory = 0;
            pending_op = Op.NoOp;
            update_screen_action("0");
        }

        void clearEntry(object arg)
        {
            state = States.Init;
            Screen = string.Empty;
            negative = false;
            update_screen_action("0");
        }

        void do_pending_op()
        {
            double val = double.Parse(Screen);
            switch (pending_op)
            {
                case Op.NoOp:
                    Result = val;
                    break;
                case Op.Add:
                    Result += val;
                    break;
                case Op.Sub:
                    Result -= val;
                    break;
                case Op.Mul:
                    Result *= val;
                    break;
                case Op.Div:
                    Result /= val;
                    break;
                case Op.Sqrt:
                    Result = Math.Sqrt(Result);
                    Screen = Result.ToString();
                    break;
            }
        }

        public void process_event(Events ev, object arg)
        {
            var act = fsm[(int)state, (int)ev];
            if (act != null)
                act.Invoke(arg);
        }

        void digit(object arg)
        {
            char c = (char)arg;
            if (state == States.Init)
            {
                if (c == '0')
                    return;

                Screen = string.Empty;

                if (negative)
                    Screen = "-";

                state = States.Accumulate;
            }
            Screen = Screen + c;
            update_screen_action.Invoke(Screen);
        }

        void dot(object arg)
        {
            if (state == States.AccumulateDot)
            {
                return;
            }

            if (state == States.Init)
            {
                Screen = "0.";
            }
            else
            {
                Screen = Screen + '.';
            }
            state = States.AccumulateDot;
            update_screen_action.Invoke(Screen);

        }

        void add(object arg)
        {
            if (state == States.Init)
            {
                negative = false;
            }

            do_pending_op();
            negative = false;
            pending_op = Op.Add;
            state = States.Init;
            update_screen_action.Invoke(Result.ToString());
        }

        void sub(object arg)
        {
            if (state == States.Init)
            {
                negative = true;
            }
            do_pending_op();
            negative = false;
            pending_op = Op.Sub;
            state = States.Init;
            update_screen_action.Invoke(Result.ToString());
        }

        void mul(object arg)
        {
            do_pending_op();
            negative = false;
            pending_op = Op.Mul;
            state = States.Init;
            update_screen_action.Invoke(Result.ToString());
        }

        void div(object arg)
        {
            do_pending_op();
            negative = false;
            pending_op = Op.Div;
            state = States.Init;
            update_screen_action.Invoke(Result.ToString());
        }

        void equal(object arg)
        {
            do_pending_op();
            negative = false;
            //pending_op = Op.NoOp;
            state = States.Init;
            update_screen_action.Invoke(Result.ToString());
        }

        void sqrt(object arg)
        {
            if (pending_op != Op.Sqrt)
                do_pending_op();
            negative = false;
            pending_op = Op.Sqrt;
            state = States.Init;
            process_event(Events.Equals, null);
            update_screen_action.Invoke(Result.ToString());
        }

        void percent(object arg)
        {
            if (pending_op == Op.Add)
            {
                Result += (Result / 100.0) * double.Parse(Screen);
            }

            if (pending_op == Op.Sub)
            {
                Result -= (Result / 100.0) * double.Parse(Screen);
            }
            negative = false;
            state = States.Init;
            update_screen_action.Invoke(Result.ToString());
        }

        void reciproc(object arg)
        {
            do_pending_op();
            negative = false;
            Result = 1.0 / Result;
            pending_op = Op.NoOp;
            state = States.Init;
            Screen = Result.ToString();
            update_screen_action.Invoke(Screen);
        }

        void sign(object arg)
        {
            Screen = (double.Parse(Screen) * -1.0).ToString();
            update_screen_action.Invoke(Screen);
        }

        void del(object arg)
        {
            Screen = Screen.Remove(Screen.Length - 1);
            if (Screen.Length == 0)
            {
                state = States.Init;
                update_screen_action.Invoke("0");
            }
            else
            {
                update_screen_action.Invoke(Screen);
            }
        }
    }
}
