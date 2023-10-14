using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    abstract class Signal
    {

        private string idName;

        public SignalType signalType { get; set; }

        public Signal()
        {
            IdName = "NotAsigned";
        }

        public Signal(String idName, SignalType signalType)
        {
            this.IdName = idName;
            this.signalType = signalType;
        }

        public string IdName { get => idName; set => idName = value; }

        public void RegisterValue()
        {
        }

        public void ShowValues()
        {
        }

        public override string ToString()
        {
            return IdName + " - " + signalType;
        }

    }
}
