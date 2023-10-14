﻿using System;
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
                    i++;
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
                        Console.WriteLine(signals[i].ToString());
                        
                    }
                    i++;
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

        public void mostrarCadena()
        {
            int i = 0;
            while (i < signals.Count)
            {
                Console.WriteLine(signals[i].ToString());
                i++;
            }
        }

    }
}