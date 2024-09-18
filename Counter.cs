﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClockProject2
{
    public class Counter
    {
        private int _count;
        private string _name;
        public int Ticks
        {
            get
            {
                return _count;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }
        public void Increment()
        {
            _count++;
        }
        public void Reset()
        {
            _count = 0;
        }
    }
}