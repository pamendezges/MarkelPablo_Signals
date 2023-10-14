using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    class AnalogSignal : Signal
    {
        List<AnalogData> analogDatas = new List<AnalogData>();

        public AnalogSignal() : this(string.Empty) { }

        public AnalogSignal(string idName) : base(idName, SignalType.Analog)
        {
            analogDatas = new List<AnalogData>();
        }

        public void RegisterValue(AnalogData analogData)
        {
            analogDatas.Add(analogData);
        }

        public override string ToString()
        {
            return IdName + " - " + signalType ;
        }
    }
}
