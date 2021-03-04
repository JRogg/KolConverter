using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolConverter
{
    class RuneCounter
    {
        public string RuneName { get; set; }
        public int Cnt { get; set; }

        public RuneCounter()
        {
        }

        public RuneCounter(string stringValue)
        {
            RuneName = stringValue;
            Cnt = 1;
        }


    }
}
