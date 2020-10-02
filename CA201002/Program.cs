using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201002
{
    class Program
    {
        static void Main()
        {
            //eljárás
            Ugass();

            //függvény
            int perc = EnnyiPercTeltElAzOrabol();
            Console.WriteLine(perc);


            //egyszerű paraméterek
            int x = 3;
            IrdKi(x, "trambulin");

            Console.WriteLine(x);

            var sum = Osszead(20, 30);
            Console.WriteLine(sum);

            //"felsorolásos" paraméter
            var sum2 = AdvancedOsszeg(32, 21, 232, 424, 2424);
            AdvancedOsszeg(new int[] { 32, 21, 232, 424, 2424 });


            //referencia vagy "átmenő" paraméter
            int atmeno = 20;
            RandomRefEljaras(ref atmeno);
            Console.WriteLine(atmeno);
            

            //"kimenő" paraméter
            string kimeno = "dfgdhg";
            RandomKimenoParameretesEljaras(out kimeno);
            Console.WriteLine(kimeno);

            Console.ReadKey();
        }

        private static void RandomKimenoParameretesEljaras(out string kimeno)
        {

            //elvis operátor: (logikai kif.) ? [érték, ha a kif. igaz] : [érték ha a kif. hamis]
            kimeno = 
                (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                ? "szerda" : "nem szerda";
        }

        private static void RandomRefEljaras(ref int d)
        {
            if (d > 0) d = 0;
        }

        private static int AdvancedOsszeg(params int[] x)
        {
            return x.Sum();
        }

        private static int Osszead(int x, int y)
        {
            return x + y;
        }

        private static void IrdKi(int x, string szoveg)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(szoveg);
            }
        }

        private static int EnnyiPercTeltElAzOrabol()
        {
            return (int)(DateTime.Now - new DateTime(2020, 10, 02, 08, 00, 00)).TotalMinutes;
        }

        private static void Ugass()
        {
            Console.WriteLine("vau-vau!");
        }
    }
}
