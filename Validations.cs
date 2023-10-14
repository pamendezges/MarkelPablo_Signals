using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    class Validations
    {
        public int ReadInt()
        {
            int num = 0;
            bool isNum = true;

            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());

                    isNum = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dato incorrecto, inserta un número, por favor");
                    isNum = false;
                }

            } while (!isNum);

            return num;
        }

        public string ReadString()
        {
            string text = "";
            bool isString = true;

            do
            {
                try
                {
                    text = Console.ReadLine();

                    isString = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dato incorrecto, inserta una cadena de texto, por favor");
                    isString = false;
                }

            } while (!isString);

            return text;
        }

        public bool ReadBool()
        {
            bool text = false;
            bool isNumber = true;

            do
            {
                try
                {
                    text = Convert.ToBoolean(Console.ReadLine());

                    isNumber = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dato incorrecto, inserta un booleano, por favor");
                    isNumber = false;
                }

            } while (!isNumber);

            return text;
        }
    }
}
