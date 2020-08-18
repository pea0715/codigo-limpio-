using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {



            Console.WriteLine("cuantos galones desea echar");
            int gasolina = int.Parse(Console.ReadLine());
            Console.WriteLine("1 si es particular y 2 para ser taxi");
            int carro = int.Parse(Console.ReadLine());

            switch (carro)
            {
                case 1:
                    Console.WriteLine("tipo de gasolina que le desea echar 1.corriente ,2.extra ,3.diesel");
                    int tipo_gasolina = int.Parse(Console.ReadLine());

                    switch (tipo_gasolina)
                    {
                        case 1:
                            int gasolina_corriente = 8500;
                            int multi1 = gasolina_corriente * gasolina;

                            Console.Write("el valor que debe pagar es : " + multi1);

                            Console.WriteLine("------------------------------------------");

                            Console.WriteLine("1 si tiene tarjeta de cliente frecuente y 2 si no tiene tarjeta ");
                            int tarjeta_cliente = int.Parse(Console.ReadLine());
                            switch (tarjeta_cliente)
                            {
                                case 1:
                                    double descuento = 0.05;
                                    int des = (int)(descuento * multi1);
                                    int res = (int)(multi1 - des);
                                    Console.WriteLine("valor que debe  pagar con el descuento : " + res);

                                    break;
                            }

                            break;

                        case 2:
                            int gasolina_extra = 10400;
                            int multi2 = gasolina_extra * gasolina;

                            Console.Write("el valor que debe pagar es : " + multi2);

                            Console.WriteLine("------------------------------------------");

                            Console.WriteLine("1 si tiene tarjeta de cliente frecuente y 2 si no tiene tarjeta ");
                            int tarjeta_cliente1 = int.Parse(Console.ReadLine());
                            switch (tarjeta_cliente1)
                            {
                                case 1:
                                    double descuento = 0.07;
                                    int des = (int)(descuento * multi2);
                                    int res = (int)(multi2 - des);
                                    Console.WriteLine("valor que debe  pagar con el descuento : " + res);
                                    break;
                            }

                            break;

                        case 3:
                            int diesel = 6500;
                            int multi3 = diesel * gasolina;

                            Console.Write("el valor que debe pagar es : " + multi3);

                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("1 si tiene tarjeta de cliente frecuente y 2 si no tiene tarjeta ");
                            int tarjeta_cliente2 = int.Parse(Console.ReadLine());
                            switch (tarjeta_cliente2)
                            {
                                case 1:
                                    double descuento = 0.03;
                                    int des = (int)(descuento * multi3);
                                    int res = (int)(multi3 - des);
                                    Console.WriteLine("valor que debe  pagar con el descuento : " + res);


                                    break;
                            }
                            break;

                        default:
                            break;
                    }


                    break;

                case 2:
                    Console.WriteLine("tipo de gasolina que le desea echar 1.corriente ,2.extra ,3.diesel");
                    int tipo_gasolina1 = int.Parse(Console.ReadLine());

                    switch (tipo_gasolina1)
                    {
                        case 1:
                            int gasolina_corriente = 8400;
                            int multi1 = gasolina_corriente * gasolina;

                            Console.Write("el valor que debe pagar es : " + multi1);

                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine(gasolina_corriente);
                            Console.WriteLine("1 si tiene tarjeta de cliente frecuente y 2 si no tiene tarjeta ");
                            int tarjeta_cliente = int.Parse(Console.ReadLine());
                            switch (tarjeta_cliente)
                            {
                                case 1:
                                    double descuento = 0.05;
                                    int des = (int)(descuento * multi1);
                                    int res = (int)(multi1 - des);
                                    Console.WriteLine("valor que debe  pagar con el descuento : " + res);

                                    break;
                            }



                            break;

                        case 2:
                            int gasolina_extra = 10200;
                            int multi2 = gasolina_extra * gasolina;

                            Console.Write("el valor que debe pagar es : " + multi2);

                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("1 si tiene tarjeta de cliente frecuente y 2 si no tiene tarjeta ");
                            int tarjeta_cliente1 = int.Parse(Console.ReadLine());
                            switch (tarjeta_cliente1)
                            {
                                case 1:
                                    double descuento = 0.07;
                                    int des = (int)(descuento * multi2);
                                    int res = (int)(multi2 - des);
                                    Console.WriteLine("valor que debe  pagar con el descuento : " + res);

                                    break;
                            }

                            break;

                        case 3:
                            int diesel = 6300;
                            int multi3 = diesel * gasolina;

                            Console.Write("el valor que debe pagar es : " + multi3);

                            Console.WriteLine("------------------------------------------");

                            Console.WriteLine("1 si tiene tarjeta de cliente frecuente y 2 si no tiene tarjeta ");
                            int tarjeta_cliente2 = int.Parse(Console.ReadLine());
                            switch (tarjeta_cliente2)
                            {
                                case 1:
                                    double descuento = 0.03;
                                    int des = (int)(descuento * multi3);
                                    int res = (int)(multi3 - des);
                                    Console.WriteLine("valor que debe  pagar con el descuento : " + res);

                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;



            }


        }





    }

}
