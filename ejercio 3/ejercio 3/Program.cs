using System;

namespace ejercio_3
{
    class Program
    {
        private static int candidato;
        private static int candidato2;
        private static int candidato3;
        private static int candidato4;
        private static int candidato5;
        private static int candidato6;
        private static int porcentaje1;
        private static int porcentaje2;
        private static int porcentaje3;
        private static int porcentaje4;
        private static int porcentaje5;
        private static int porcentaje6;
        private static int cantidad5;

        static void Main(string[] args)
        {


            var seed = Environment.TickCount;
            var random = new Random(seed);


            candidato = 0;
            candidato2 = 0;
            candidato3 = 0;
            candidato4 = 0;
            candidato5 = 0;
            candidato6 = 0;
            int votos = 5;

            for (int i = 0; i < votos; i++)
            {

                Console.WriteLine("oprima 1 para candidato A , 2 para candidato B ,3 para candidato C ,4 para candidato D , 5 para candidato E ,6 para boto en blanco ");
                int value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        candidato++;
                        break;

                    case 2:
                        candidato2++;
                        break;

                    case 3:
                        candidato3++;
                        break;
                    case 4:
                        candidato4++;
                        break;

                    case 5:
                        candidato5++;
                        break;

                    case 6:
                        candidato6++;
                        break;





                }
            }
            porcentaje1 = (candidato * 100) / votos;
            Console.WriteLine("candidato A :" + porcentaje1 + "%");
            porcentaje2 = (candidato2 * 100) / votos;
            Console.WriteLine("candidato B :" + porcentaje2 + "%");
            porcentaje3 = (candidato3 * 100) / votos;
            Console.WriteLine("candidato C :" + porcentaje3 + "%");
            porcentaje4 = (candidato4 * 100) / votos;
            Console.WriteLine("candidato D :" + porcentaje4 + "%");
            porcentaje5 = (candidato5 * 100) / votos;
            Console.WriteLine("candidato E :" + porcentaje5 + "%");
            porcentaje6 = (candidato6 * 100) / votos;
            Console.WriteLine("candidato F :" + porcentaje6 + "%");


            if (candidato > candidato2 && candidato > candidato3 && candidato > candidato4 && candidato > candidato5 && candidato > candidato6)
            {
                Console.WriteLine("el codigo del candidato ganar es : A");
            }
            else if (candidato2 > candidato3 && candidato2 > candidato4 && candidato2 > candidato5 && candidato2 > candidato6)

            {
                Console.WriteLine("el codigo del candidato ganar es : B ");
            }
            else if (candidato3 > candidato4 && candidato3 > candidato5 && candidato3 > candidato6)
            {
                Console.WriteLine("el codigo del candidato ganar es : c ");
            }
            else if (candidato4 > candidato5 && candidato4 > candidato6)
            {
                Console.WriteLine("el codigo del candidato ganar es : D ");
            }
            else if (candidato5 > candidato6)
            {
                Console.WriteLine("el codigo del candidato ganar es : E");
            }
            else
                Console.WriteLine("el codigo del candidato ganar es : F ");

            Console.WriteLine("total de numero de botos blancos :" + candidato6);



            if (candidato < candidato2 && candidato < candidato3 && candidato < candidato4 && candidato < candidato5 && candidato < candidato6)
            {
                Console.WriteLine("el codigo del candidato menor es : A");
            }
            else if (candidato2 < candidato3 && candidato2 < candidato4 && candidato2 < candidato5 && candidato2 < candidato6)

            {
                Console.WriteLine("el codigo del candidato menor es : B ");
            }
            else if (candidato3 < candidato4 && candidato3 < candidato5 && candidato3 < candidato6)
            {
                Console.WriteLine("el codigo del candidato menor es : c ");
            }
            else if (candidato4 < candidato5 && candidato4 < candidato6)
            {
                Console.WriteLine("el codigo del candidato menor es : D ");
            }
            else if (candidato5 < candidato6)
            {
                Console.WriteLine("el codigo del candidato menor es : E");
            }
            else
                Console.WriteLine("el codigo del candidato menor es : F ");






        }
    }
}
