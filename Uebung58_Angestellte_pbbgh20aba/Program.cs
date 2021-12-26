using System;

namespace Uebung58_Angestellte_pbbgh20aba
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // Birinci yöntem yazdirmak icin
            Angestellter a = new Angestellter(2000);
            Sekretaerin s = new Sekretaerin(1200, a);
            Verkaufer v = new Verkaufer(2500, 100);


            Console.WriteLine(a);
            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine();


            //ikinci yöntem yazdirmak icin
            Angestellter[] angestellte = { a, s, v };
            for (int i = 0; i < angestellte.Length; i++)
            {
                Console.WriteLine(angestellte[i]);
                Console.WriteLine(angestellte[i].BerechneMonatsgehalt());
                Console.WriteLine(angestellte[i].Berechnejahresgehalt());
                Console.WriteLine();
            }

            // Manager metodu icin yazdirma yöntemi:

            Angestellter a1 = new Angestellter(2000);
            Angestellter a2 = new Angestellter(1800);
            Angestellter a3 = new Angestellter(2100);
            Sekretaerin ss = new Sekretaerin(1200, a1);
            Verkaufer vv = new Verkaufer(2500, 100);

            Angestellter[] angestellterOhneChef = { a1, a2, a3, s, v };
            Manager m = new Manager(5000, 1000, angestellterOhneChef, true, 11);
            Angestellter[] angestellter = { a1, a2, a3, ss, vv };
            for (int i = 0; i < angestellte.Length; i++)
            {
                Console.WriteLine(angestellter[i]);
                Console.WriteLine(angestellter[i].BerechneMonatsgehalt());
                Console.WriteLine(angestellter[i].Berechnejahresgehalt());
                Console.WriteLine();
            }


        }
    }
}
