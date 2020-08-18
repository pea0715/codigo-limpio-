using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace new_programin
{
    class Program
    {
        static void Main(string[] args)
        {
            double multi1;
            double descuento;
            Console.WriteLine("si es de pregrado oprima 1 y si es posgrado ingrese el 2");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("ingrese su promedio :");
                    double promedio = double.Parse(Console.ReadLine());
                    double materia = 50000;

                    if (promedio >= 4.5)
                    {
                        multi1 = 28 * materia;
                        descuento = multi1 * 0.25;

                        Console.Write("este el valor que debe pagar con el descuento incluido " + descuento);
                        Console.ReadLine();

                    }
                    else if (promedio >= 4.0)
                    {
                        multi1 = 25 * materia;
                        descuento = multi1 * 0.10;

                        Console.Write("este el valor que debe pagar con el descuento incluido " + descuento);
                        Console.ReadLine();


                    }
                    else if (promedio >= 3.5)
                    {
                        multi1 = 20 * materia;


                        Console.Write("este el valor que debe pagar :" + multi1);
                        Console.ReadLine();


                    }
                    else if (promedio >= 2.5)
                    {
                        multi1 = 15 * materia;


                        Console.Write("este el valor que debe pagar :" + multi1);


                    }
                    else if (promedio < 2.5)
                    {

                        Console.Write("usted no se podra matricular ");


                    }
                    break;
                case 2:
                    Console.WriteLine("ingrese su promedio :");
                    double promediom = double.Parse(Console.ReadLine());
                    double materiam = 300000;

                    if (promediom >= 4.5)
                    {
                        multi1 = 20 * materiam;
                        descuento = multi1 * 0.20;

                        Console.Write("este el valor que debe pagar con el descuento incluido " + descuento);


                    }
                    else if (promediom < 4.5)
                    {
                        multi1 = 10 * materiam;


                        Console.Write("este el valor que debe pagar : " + multi1);


                    }

                    break;


            }





        }
    }
}


