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
                Console.WriteLine("4) Registrar valor analogico");
                Console.WriteLine("5) Registrar valor digital");
                Console.WriteLine("6) Mostrar una señal por nombre");
                Console.WriteLine("7) Mostrar una señal por fecha de creacion");
                Console.WriteLine("0) Salir");
                menuOption = Convert.ToInt32(Console.ReadLine()); //CONTROLAR EXCEPCIÓN SOLO ENTEROS.

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
                        AddAnalogParameter(signals);
                        break;
                    case 5:
                        AddDigitalParameter(signals);
                        break;
                    case 6:
                        //llama a CallSignalByName();
                        break;
                    case 7:
                        //llama a CallSignalByTime();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.WriteLine("ESCOJA UNA DE LAS OPCIONES DISPONIBLES, POR FAVOR"); 
                        Console.Read(); 
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
            Console.WriteLine("Introduce un entero: ");
            int value = Convert.ToInt32(Console.ReadLine());
            AnalogData dataSignal = new AnalogData(value);
            analogSignal.RegisterValue(dataSignal);
        }

        public static void AskDigitalParameter(DigitalSignal digitalSignal)
        {
            Console.WriteLine("Introduce un valor 'true' o 'false': ");
            bool value = Convert.ToBoolean(Console.ReadLine());
            DigitalData dataSignal = new DigitalData(value);
            digitalSignal.RegisterValue(dataSignal);
        }

        public static void AddAnalogParameter(Signals signals)
        {

            int index ;
            do
            {
                Console.WriteLine("Por favor introduzca el NOMBRE de la señal: ");
                string signalId = Console.ReadLine();
                index = signals.GetSignalIndex(signalId, SignalType.Analog);
                if (index == -1)
                {
                    Console.WriteLine("No existe una señal de tipo Analog con ese nombre.");
                }
                else
                {
                    AnalogSignal signalNew = (AnalogSignal)signals.GetSignal(index);
                    AskAnalogParameter(signalNew);
                    signals.SubstituteSignal(signalNew, index);
                    Console.Write(signalNew.ToString());
                    signalNew.ShowValues();
                    Console.WriteLine(" \r\n ");
                }
            } while (index ==-1);
            
        }

        public static void AddDigitalParameter(Signals signals)
        {
            int index;
            do
            {
                Console.WriteLine("Por favor introduzca el NOMBRE de la señal: ");
                string signalId = Console.ReadLine();
                index = signals.GetSignalIndex(signalId, SignalType.Digital);
                if (index == -1)
                {
                    Console.WriteLine("No existe una señal de tipo Digital con ese nombre.");
                }
                else
                {
                    DigitalSignal signalNew = (DigitalSignal)signals.GetSignal(index);
                    AskDigitalParameter(signalNew);
                    signals.SubstituteSignal(signalNew, index);
                    Console.Write(signalNew.ToString());
                    signalNew.ShowValues();
                    Console.WriteLine(" \r\n ");
                }
            } while (index == -1);
        }

    }
}
