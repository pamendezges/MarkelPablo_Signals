using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkelPablo_Signals
{
    class Program
    {

        public static void Main(string[] args)
        {
            Signals signals1 = new Signals();

            menu(signals1);
        }

        public static void menu(Signals signals)
        {
            int menuOption;
            do
            {
                Console.WriteLine("Este es el menu principal, seleccione una opcion por favor:");
                Console.WriteLine("1) Añadir una señal analogica");
                Console.WriteLine("2) Añadir una señal digital");
                Console.WriteLine("3) Borrar una señal");
                Console.WriteLine("4) Guardar señales en archivo");
                Console.WriteLine("5) Mostrar una señal por nombre");
                Console.WriteLine("6) Mostrar una señal por fecha de creacion");
                Console.WriteLine("0) Salir");
                menuOption = Convert.ToInt32(Console.ReadLine());

                switch (menuOption)
                {
                    case 1:
                        CreateSignalAnalog(signals);
                        signals.mostrarCadena();
                        break;
                    case 2:
                        CreateSignalDigital(signals);
                        signals.mostrarCadena();
                        break;
                    case 3:
                        Console.WriteLine("Introduce el idName de la señal que quiere borrar:");
                        string name = Console.ReadLine();
                        signals.DeleteSignal(name);
                        break;
                    case 4:
                        //llama a saveSignalFile();
                        break;
                    case 5:
                        //llama a CallSignalByName();
                        break;
                    case 6:
                        //llama a CallSignalByTime();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (menuOption != 0);
        }

        public static void CreateSignalAnalog(Signals signals)
        {
            AnalogSignal newAnalogSignal = new AnalogSignal();
            AskCommonParameters(newAnalogSignal);
            AskAnalogParameter(newAnalogSignal);
            signals.AddSignal(newAnalogSignal);
        }

        public static void CreateSignalDigital(Signals signals)
        {
            DigitalSignal newDigitalSignal = new DigitalSignal();
            AskCommonParameters(newDigitalSignal);
            AskDigitalParameter(newDigitalSignal);
            signals.AddSignal(newDigitalSignal);
        }

        public static void AskCommonParameters(Signal signal)
        {
            Console.WriteLine("Por favor introduzca el nombre de la señal: ");
            signal.IdName = Console.ReadLine();
        }

        public static void AskAnalogParameter(AnalogSignal analogSignal)
        {
            Console.WriteLine("Introduce un valor entero: ");
            analogSignal.Value = Convert.ToInt32(Console.ReadLine());
            analogSignal.signalType = SignalType.Analog;
        }

        public static void AskDigitalParameter(DigitalSignal digitalSignal)
        {
            Console.WriteLine("Introduce un valor 'true' o 'false': ");
            digitalSignal.Value = Convert.ToBoolean(Console.ReadLine());
            digitalSignal.signalType = SignalType.Digital;
        }

    }
}
