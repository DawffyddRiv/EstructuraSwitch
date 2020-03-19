using System;

namespace EstructuraSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, aqui probando la estructura Switch");
            
            //EstructuraSwitch();
            Switchdonas();
        }
        static void Switchdonas()
        {//Programa que debe calcular la comisión para una serie de conversiones y dependiendo del mes, la comisión sera calculada
            Console.WriteLine("Introduce el número de mes para cálculo de la comisión");
            int nMes = Int32.Parse(Console.ReadLine());

            switch (nMes)
            {
                case 1:
                    Console.WriteLine("Mes escogido: Enero ");
                break;
                
                case 2:
                    Console.WriteLine("Mes escogido: Febrero ");
                break;

                case 3:
                    Console.WriteLine("Mes escogido: Marzo ");
                    break;
                case 4:
                    Console.WriteLine("Mes escogido: Abril ");
                    break;
                case 5:
                    Console.WriteLine("Mes escogido: Mayo ");
                    break;
                case 6:
                    Console.WriteLine("Mes escogido: Junio ");
                    break;
                case 7:
                    Console.WriteLine("Mes escogido: Julio ");
                    break;
                case 8:
                    Console.WriteLine("Mes escogido: Agosto ");
                    break;
                case 9:
                    Console.WriteLine("Mes escogido: Septiembre ");
                    break;
                case 10:
                    Console.WriteLine("Mes escogido: Octubre ");
                    break;
                case 11:
                    Console.WriteLine("Mes escogido: Noviembre ");
                    break;
                case 12:
                    Console.WriteLine("Mes escogido: Diciembre ");
                    break;

                default:
                    Console.WriteLine("Tecleaste un número para un mes incorrecto");
                    break;
                                       
            }
            Console.WriteLine("Ha terminado el programa de los meses");

        }
        static void EstructuraSwitch()
        {///Programa para que nos pregunten sobre la elección de un medio de transporte para un viaje
            Console.WriteLine("Elige un medio de transporte: automóvil, tren o avión");
            string medioTransporte = Console.ReadLine();
            switch (medioTransporte)
            {
                case "automóvil":
                    Console.WriteLine("Tu velocidad de viaje máxima será de 100 km/h");
                    break;
                case "tren":
                    Console.WriteLine("Tu velocidad media de viaje será de 250 km/h");
                    break;
                case "avión":
                    Console.WriteLine("Tu velocidad media de viaje será de 800 km/h");
                    break;
                default:
                    Console.WriteLine("No elegiste ningún transporte listado");
                    break;
            }
            Console.WriteLine("Ha terminado el programa");
        }
    }
}
