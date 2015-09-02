using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball();
            Console.WriteLine("Rola a bola na tela da Globo");
            ball.GetState();
            String read = null;
            while (read != "q" && (read == null || read == ""))
            {
                int action = Actions();
                ball.Play(action);
                ball.GetState();
                read = Console.ReadLine();
            }
        }

        static int Actions()
        {
            String read = null;
            int value = -1;
            while (value <= 0 || value > 4)
            {
                Console.WriteLine("Choose an action");
                Console.WriteLine("1 - Pass");
                Console.WriteLine("2 - Long pass");
                Console.WriteLine("3 - Freekick");
                Console.WriteLine("4 - Dominate");
                Console.WriteLine("");
                read = Console.ReadLine();
                Int32.TryParse(read, out value);
            }
            return value;
        }
    }
}
