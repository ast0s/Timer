using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class Timer
    {
        public int seconds;
        public Timer(int seconds) { this.seconds = seconds; }
        public void Tick() => Thread.Sleep(999);
        public void ShowMessage() => Console.WriteLine($"Пройшло {seconds} секунд");
    }
}
