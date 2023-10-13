using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    class AnalogData : Data
    {
        private int value;

        public AnalogData(int value): base(DateTime.UtcNow)
        {
            this.Value = value;
        }

        public int Value { get => value; set => this.value = value; }
    }
}
