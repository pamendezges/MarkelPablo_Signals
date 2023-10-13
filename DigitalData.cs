using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    class DigitalData : Data
    {
        private bool value;

        public DigitalData(bool value): base(DateTime.UtcNow)
        {
            this.Value = value;
        }

        public bool Value { get => value; set => this.value = value; }
    }
}
