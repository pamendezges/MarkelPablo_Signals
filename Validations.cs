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
            bool esNumero = true;

            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());

                    esNumero = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dato incorrecto, inserta un número, por favor");
                    esNumero = false;
                }

            } while (!esNumero);

            return num;
        }

        public string ReadString()
        {
            string texto = "";
            bool esCadena = true;

            do
            {
                try
                {
                    texto = Console.ReadLine();

                    esCadena = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dato incorrecto, inserta una cadena de texto, por favor");
                    esCadena = false;
                }

            } while (!esCadena);

            return texto;
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
