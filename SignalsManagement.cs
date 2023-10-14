using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    interface SignalsManagement
    {

        abstract public void AddSignal(Signal signal);

        abstract public void DeleteSignal(string id);

        abstract public bool AlreadyRegistered(string id);

        abstract public void CallSignalByName(string id);

        abstract public void CallSignalByTime(DateTime timeStart, DateTime timeEnd);

        abstract public void PrintList();

        abstract public int GetSignalIndex(string id, SignalType signalType);

        abstract public Signal GetSignal(int index);

        abstract public void ReplaceSignal(Signal signal, int index);

    }
}
