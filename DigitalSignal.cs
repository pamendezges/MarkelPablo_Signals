﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    class DigitalSignal : Signal
    {
        List<DigitalData> digitalDatas = new List<DigitalData>();

        public DigitalSignal() : this(string.Empty) { }

        public DigitalSignal(string idName) : base(idName, SignalType.Digital)
        {
            digitalDatas = new List<DigitalData>();
        }

        public void RegisterValue(DigitalData digitalData)
        {
            digitalDatas.Add(digitalData);
        }

        public override string ToString()
        {
            return IdName + " - " + signalType ;
        }
    }
}