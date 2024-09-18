using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClockProject2
{
    public class Clock
    {
        private Counter seconds;
        private Counter minutes;
        private Counter hours;
        public Clock()
        {
            seconds = new Counter("seconds");
            minutes = new Counter("minutes");
            hours = new Counter("hours");
        }
        public void Tick()
        {
            if (seconds.Ticks != 59)
            {
                seconds.Increment();
            }
            else if (minutes.Ticks != 59 && seconds.Ticks == 59)
            {
                minutes.Increment();
                seconds.Reset();
            }
            else
            {
                hours.Increment();
                minutes.Reset();
                seconds.Reset();
            }

            if (hours.Ticks == 24)
            {
                hours.Reset();
                minutes.Reset();
                seconds.Reset();
            }
        }
        public string Read()
        {
            return $"{hours.Ticks:D2}:{minutes.Ticks:D2}:{seconds.Ticks:D2}";
        }
        public void Reset()
        {
            seconds.Reset();
            minutes.Reset();
            hours.Reset();
        }
    }
}