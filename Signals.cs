using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    class Signals
    {
        List<Signal> signals = new List<Signal>();

        public Signals()
        {
            signals = new List<Signal>();
        }

        public void AddSignal(Signal signal)
        {
            bool signalExists = signals.Any(s => s.IdName == signal.IdName);

            if (!signalExists)
            {
                signals.Add(signal);
            }
            else
            {
                Console.WriteLine("LAS SEÑALES SON ÚNICAS, NO PUEDES AÑADIR 2 IGUALES");
            }
}

        public void DeleteSignal(String id)
        {
            if (id != null)
            {
                bool exists = false;

                for (int i = 0; i < signals.Count() && !exists; i++)
                {
                    if (signals[i].IdName == id)
                    {
                        signals.RemoveAt(i);
                        exists = true;
                    }
                }
                if (!exists)
                {
                    Console.WriteLine("La señal no se ha encontrado en la lista.");
                }

            }
            else
            {
                Console.WriteLine("Introduce un nombre que no sea nulo.");
            }
        }

        public bool AlreadyRegistered(String id)
        {
            bool signalExists = signals.Any(s => s.IdName == id);
            if (signalExists == true)
            {
                return true;
            }
            else
            {
                Console.WriteLine("No puedes añadir valores a una señal no registrada.");
                return false;
            }
        }

        public void CallSignalByName(String id)
        {
            if (id != null)
            {
                bool exists = false;
                for (int i = 0; i < signals.Count() && !exists; i++)
                {
                    if (signals[i].IdName == id)
                    {
                        if (signals[i].signalType.Equals(SignalType.Analog))
                        {
                            AnalogSignal signal = (AnalogSignal)signals[i];
                            Console.Write("DATOS: " + signal.ToString());
                            signal.ShowValues();
                            Console.WriteLine(" \r\n ");
                        }
                        else if (signals[i].signalType.Equals(SignalType.Digital))
                        {
                            DigitalSignal signal = (DigitalSignal)signals[i];
                            Console.Write(signal.ToString());
                            signal.ShowValues();
                            Console.WriteLine(" \r\n ");
                        }
                        exists = true;
                    }
                }
                if (!exists)
                {
                    Console.WriteLine("La señal no se ha encontrado en la lista.");
                }
            }
            else
            {
                Console.WriteLine("Introduce un nombre que no sea nulo.");
            }
        }

        public void CallSignalByTime(DateTime timeStart, DateTime timeEnd)
        {
            if (timeStart != null && timeEnd != null)
            {
                bool exists = false;
                for (int i = 0; i < signals.Count() && !exists; i++)
                {
                    if (signals[i].signalType.Equals(SignalType.Analog))
                    {
                        AnalogSignal signal = (AnalogSignal)signals[i];
                        signal.ShowValuesIfDates(timeStart, timeEnd);
                        Console.WriteLine(" \r\n ");
                    }
                    else if (signals[i].signalType.Equals(SignalType.Digital))
                    {
                        DigitalSignal signal = (DigitalSignal)signals[i];
                        signal.ShowValuesIfDates(timeStart, timeEnd);
                        Console.WriteLine(" \r\n ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Introduce un nombre que no sea nulo.");
            }
        }

        public void mostrarCadena()
        {
            int i = 0;
            while (i < signals.Count)
            {
                Console.WriteLine(signals[i].ToString());
                i++;
            }
        }

        public int GetSignalIndex(string id, SignalType signalType)
        {
            int index = -1;
            for (int i = 0; i < signals.Count(); i++)
            {
                if (signals[i].IdName == id && signals[i].signalType.Equals(signalType))
                {
                    index = i;
                }
            }
            return index;
        }

        public Signal GetSignal(int i)
        {
            return signals[i];
        }

        public void SubstituteSignal(Signal signal, int index)
        {
            bool signalExists = signals.Any(s => s.IdName == signal.IdName);

            if (!signalExists)
            {
                signals[index] = signal;
            }

        }

    }
}
