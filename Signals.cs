using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    class Signals : SignalsManagement
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

        public void DeleteSignal(string id)
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

        public bool AlreadyRegistered(string id)
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

        public void CallSignalByName(string id)
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
                    }
                    else if (signals[i].signalType.Equals(SignalType.Digital))
                    {
                        DigitalSignal signal = (DigitalSignal)signals[i];
                        signal.ShowValuesIfDates(timeStart, timeEnd);
                    }
                }
                Console.WriteLine(" \r\n ");
            }
            else
            {
                Console.WriteLine("Introduce un nombre que no sea nulo.");
            }
        }

        public void PrintList()
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

        public Signal GetSignal(int index)
        {
            return signals[index];
        }

        public void ReplaceSignal(Signal signal, int index)
        {
            bool signalExists = signals.Any(s => s.IdName == signal.IdName);

            if (!signalExists)
            {
                signals[index] = signal;
            }

        }

        public void AverageValue(string id)
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
                            signal.CalculateAverage();
                            Console.WriteLine(" \r\n ");
                        }
                        else if (signals[i].signalType.Equals(SignalType.Digital))
                        {
                            DigitalSignal signal = (DigitalSignal)signals[i];
                            signal.CalculateAverage();
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

        public void MaxValueSignal()
        {
            int maxValueIndex = 0;
            int maxValue = 0;
            string maxValueSignal = "";

            for (int i = 0; i < signals.Count(); i++)
            {
                int temp = 0;
                if (signals[i].signalType.Equals(SignalType.Analog))
                {
                    AnalogSignal signal = (AnalogSignal)signals[i];
                    temp = signal.GetMaxValue();
                    if (temp > maxValue)
                    {
                        maxValue = temp;
                        maxValueIndex = i;
                    }
                }
            }
            Console.WriteLine(signals[maxValueIndex].ToString() + " VALOR MÁXIMO = " + maxValue);
            Console.WriteLine(" \r\n ");
        }

        public void FileSaving(FileManagement file)
        {
            file.SaveToFile(signals);
        }

    }
}
