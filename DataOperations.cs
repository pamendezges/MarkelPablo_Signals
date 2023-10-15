using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    class DataOperations : DataManagement
    {
        public void SecondaryMenu(Signals signals)
        {
            Validations validate = new Validations();

            int menuOption = 0;
            do
            {
                Console.WriteLine("Este es el menu de vista de datos específicos, seleccione una opcion por favor:");
                Console.WriteLine("1) Calcular media de valores de una señal");
                Console.WriteLine("2) Mostrar valor máximo de una señal (analógica)");
                Console.WriteLine("0) Volver al menu principal");
                Console.WriteLine("Introduzca una opción: ");
                menuOption = validate.ReadInt();

                switch (menuOption)
                {
                    case 1:
                        string name1 = "";
                        Console.WriteLine("Introduce el idName del sensor para visualizar sus datos:");
                        name1 = validate.ReadString();
                        signals.AverageValue(name1);
                        break;
                    case 2:
                        signals.MaxValueSignal();
                        break;
                    case 0:
                        Console.WriteLine("Volviendo al menu principal...");
                        break;
                    default:
                        Console.WriteLine("ESCOJA UNA DE LAS OPCIONES DISPONIBLES, POR FAVOR");
                        Console.Read();
                        break;
                }
            } while (menuOption != 0);
        }

        
    }
}
