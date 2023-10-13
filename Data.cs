using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    abstract class Data
    {
        private DateTime timeStamp;

        public Data()
        {
        }

        public Data(DateTime timeStamp)
        {
            this.timeStamp = timeStamp;
        }

        public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
    }
}
