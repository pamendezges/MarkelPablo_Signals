using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    class FileManagement
    {

        public void SaveToFile(List<Signal> signals)
        {
            string path = @"C:\Users\pamendez\Documents\test.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Signal s in signals)
                {
                    if (s.signalType.Equals(SignalType.Analog))
                    {
                        AnalogSignal signal = (AnalogSignal)s;
                        sw.WriteLine(signal.GetValues());
                    }
                    else if (s.signalType.Equals(SignalType.Digital))
                    {
                        DigitalSignal signal = (DigitalSignal)s;
                        sw.WriteLine(signal.GetValues());
                    }

                }
                    
            }
            Console.WriteLine(" \r\n ");
        }

    }
}
