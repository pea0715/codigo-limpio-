using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO #2 COVID-19

            string nombre_instituciones;
            int N;
            int pacientes_covid;
            int pacientes_recuperados;
            int camas_uci;
            int camas_uci_ocupadas;
            int total_camas_libres = 0;
            int personas_recuperadas = 0;
            int numero_de_camas_disponible = 0;

            int total_recuperados = 0;
            string nom_hospital_recuperados = "";

           
            string mayor_institucion = "";

            Console.WriteLine("Ingrese el número de instituciones clínicas y hospitalrias de la ciudad de Medellín: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            for (int i = 0; i < N; i++)
            {

                Console.WriteLine("Ingrese el nombre de la clínica u hospital: ");
                nombre_instituciones = Console.ReadLine();
                Console.WriteLine("ingrese el número de pacientes con COVID-19: ");
                pacientes_covid = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número total de recuperados: ");
                pacientes_recuperados = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número total de camas de UCI:");
                camas_uci = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número de camas de UCI ocupadas: ");
                camas_uci_ocupadas = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------");

                

                if (pacientes_recuperados > total_recuperados)
                {
                    total_recuperados = pacientes_recuperados;
                    nom_hospital_recuperados = nombre_instituciones;
                }


                int camas_disponibles = camas_uci - camas_uci_ocupadas;
                total_camas_libres += camas_disponibles;

                if (camas_disponibles > numero_de_camas_disponible)
                {
                    numero_de_camas_disponible = camas_disponibles;
                    mayor_institucion = nombre_instituciones;
                }

                personas_recuperadas += pacientes_recuperados;

            }

            Console.WriteLine("mayor numero de recuperados "+nom_hospital_recuperados );
            Console.WriteLine("camas UCI en hospitales  " + total_camas_libres );
            Console.WriteLine("hospital con mayor numero de camas UCI :" + mayor_institucion);
            Console.WriteLine("total de pacientes recuperados  :" + personas_recuperadas);

        }
    }
}