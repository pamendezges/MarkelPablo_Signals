using System;
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

        public void ShowValues()
        {
            for (int i = 0; i < digitalDatas.Count; i++)
            {
                Console.Write(" - " + digitalDatas[i].Value + "(" + digitalDatas[i].TimeStamp + ")");
            }
        }

        public string GetValues()
        {
            string values = ToString();
            for (int i = 0; i < digitalDatas.Count; i++)
            {
                values += (" - " + digitalDatas[i].Value + "(" + digitalDatas[i].TimeStamp + ")");
            }
            return values;
        }

        public void ShowValuesIfDates(DateTime timeStart, DateTime timeEnd)
        {
            for (int i = 0; i < digitalDatas.Count; i++)
            {
                if (digitalDatas[i].TimeStamp >= timeStart && digitalDatas[i].TimeStamp <= timeEnd)
                {
                    Console.Write(ToString());
                    Console.WriteLine(" - " + digitalDatas[i].Value + "(" + digitalDatas[i].TimeStamp + ")");
                }
            }
        }

        public void CalculateAverage()
        {
            int numTrue = 0;
            int numFalse = 0;

            for (int i = 0; i < digitalDatas.Count; i++)
            {
                if (digitalDatas[i].Value.Equals(true))
                {
                    numTrue++;
                } 
                else if (digitalDatas[i].Value.Equals(false))
                {
                    numFalse++;
                }
            }
            if (numTrue == numFalse)
            {
                Console.WriteLine("Se ha registrado true y false el mismo número de veces");
            } 
            else if (numTrue>numFalse)
            {
                Console.WriteLine("El valor con más registros ha sido el true con " + numTrue + " registros.");
            }
            else if (numTrue < numFalse)
            {
                Console.WriteLine("El valor con más registros ha sido el false con " + numFalse + " registros.");
            }
        }

        public override string ToString()
        {
            return IdName + " - " + signalType ;
        }
    }
}
