using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public enum BallState
    {
        Stoped, Rolling, Airbone, Curling
    }

    class Ball
    {
        protected BallState state;

        public void Pass()
        {
            state = BallState.Rolling;
        }

        public void FreeKick()
        {
            state = BallState.Curling;
        }

        public void LongPass()
        {
            state = BallState.Airbone;
        }

        public void Dominate()
        {
            state = BallState.Stoped;
        }

        public void GetState()
        {
            Console.WriteLine("\nBall State: " + state.ToString() + "\n");
        }

        public void Play(int value)
        {
            switch (value)
            {
                case 1: Pass(); break;
                case 2: LongPass(); break;
                case 3: FreeKick(); break;
                case 4: Dominate(); break;
            }
        }
    }
}
