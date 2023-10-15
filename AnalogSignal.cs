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

        public void ShowValues()
        {
            for (int i = 0; i < analogDatas.Count; i++)
            {
                Console.Write(" - " + analogDatas[i].Value + "(" + analogDatas[i].TimeStamp + ")");
            }
        }

        public void ShowValuesIfDates(DateTime timeStart, DateTime timeEnd)
        {
            for (int i = 0; i < analogDatas.Count; i++)
            {
                if (analogDatas[i].TimeStamp >= timeStart && analogDatas[i].TimeStamp <= timeEnd)
                {
                    Console.Write(ToString());
                    Console.WriteLine(" - " + analogDatas[i].Value + "(" + analogDatas[i].TimeStamp + ")");
                }
            }
        }

        public void CalculateAverage()
        {
            int sumValores = 0;
            double average = 0;

            for (int i = 0; i < analogDatas.Count; i++)
            {
                sumValores += analogDatas[i].Value; 
            }
            average = sumValores / analogDatas.Count;
            Console.WriteLine("La media de los registros es: " + average + " unidades.");
        }

        public int GetMaxValue()
        {
            int maxValue = 0;
            for (int i = 0; i < analogDatas.Count; i++)
            {
                if (analogDatas[i].Value > maxValue)
                {
                    maxValue = analogDatas[i].Value;
                }
            }
            return maxValue;
        }

        public override string ToString()
        {
            return IdName + " - " + signalType ;
        }
    }
}
