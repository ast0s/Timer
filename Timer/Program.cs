using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько секунд вы хотите бесцельно прождать?");

            Timer timer = new Timer(int.Parse(Console.ReadLine()));
            TimerMessage tm = timer.ShowMessage;

            int counter = 0;
            while (true)
            {
                timer.Tick();
                counter++;

                if (timer.seconds == counter)
                    tm.Invoke();
            }
        }
        public delegate void TimerMessage();
    }
}
