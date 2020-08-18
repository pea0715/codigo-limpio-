using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_PRACTICA_C_LIMPIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO #4 DEPORTISTAS

            string Nombre_Deportista = "";
            int Edad_Deportista;
            int Num_Medallas_Oro = 0;
            int Num_Medallas_Plata = 0;
            int Num_Medallas_Bronce = 0;
            int N;

            int Total_Medallas = 0;

            int mayor_medallas = 0;
            string nombre_jugador_mayor = "";

            int menos_medallas = 99999;
            string nombre_jugador_menor = "";

            int color_medalla_oro = 0;
            int color_medalla_plata = 0;
            int color_medalla_bronce = 0;
            int total_color_medallas = 0;
            int mas_medallas = 0;
            string nom_jugador_meda = "";

            int no_medallas = 0;

            Console.WriteLine("Ingrese el número de deportistas: ");
            N = int.Parse(Console.ReadLine());


            for (int i = 0; i < N; i++)
            {

                Console.WriteLine("Ingrese el nombre del deportista: ");
                Nombre_Deportista = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del deportista: ");
                Edad_Deportista = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número de medallas de oro obtenidas por el deportista: ");
                Num_Medallas_Oro = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número de medallas de plata obtenidas por el deportista: ");
                Num_Medallas_Plata = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número de medallas de bronce obtenidas por el deportista: ");
                Num_Medallas_Bronce = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------");

                Total_Medallas = Num_Medallas_Oro + Num_Medallas_Plata + Num_Medallas_Bronce;
                //Console.WriteLine(Total_Medallas);


                if (mayor_medallas < Total_Medallas)
                {
                    mayor_medallas = Total_Medallas;
                    nombre_jugador_mayor = Nombre_Deportista;

                }


                if (menos_medallas > Total_Medallas)
                {
                    menos_medallas = Total_Medallas;
                    nombre_jugador_menor = Nombre_Deportista;
                }

                color_medalla_oro += Num_Medallas_Oro;
                color_medalla_plata += Num_Medallas_Plata;
                color_medalla_bronce += Num_Medallas_Bronce;

            }

            if (color_medalla_oro > Num_Medallas_Plata)
            {
                color_medalla_oro = mas_medallas;
                nom_jugador_meda = Nombre_Deportista;


            }
            else if (color_medalla_plata > Num_Medallas_Bronce)
            {
                color_medalla_plata = mas_medallas;
                nom_jugador_meda = Nombre_Deportista;
            }
            else
            {
                color_medalla_bronce = mas_medallas;
                nom_jugador_meda = Nombre_Deportista;
            }

            if (N < total_color_medallas)
            {
                no_medallas++;
            }
            Console.WriteLine("El nombre del deportista que más medallas ha conseguido es: " + nombre_jugador_mayor);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("El nombre del deportista que menos medallas de oro ha conseguido es: " + nombre_jugador_menor);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("El color de medalla que representa la mayor cantidad de títulos obtenidos por los" + N + "deportistas es: " + nom_jugador_meda);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("La cantidad de deportistas que no han ganado ninguna medalla es: " + no_medallas);


        }
    }
}
