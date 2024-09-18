using ClockProject2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace CounterTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();
            int i = 0;

            while (i <= 86402)
            {
                Console.WriteLine(myClock.Read());
                myClock.Tick();
                i++;
            }
        }
    }
}