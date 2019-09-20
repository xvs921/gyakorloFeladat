using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usertolBekeres {
    class Program {
        static void Main(string[] args) {
            List<int> bekertSzamok = new List<int>();
            //darabszám
            Console.WriteLine("Hány darab elemet szeretne megadni?");
            int elemSzam = Convert.ToInt32(Console.ReadLine());
            //bekérés
            for (int i = 0; i < elemSzam; i++) {
                Console.WriteLine("Kérem adjon meg egy számot!");
                bekertSzamok.Add( Convert.ToInt32(Console.ReadLine()));
            }
            //legnagyobb
            int legnagyobb = bekertSzamok[0];
            for (int i = 0; i < bekertSzamok.Count; i++) {
                if (bekertSzamok[i]>legnagyobb) {
                    legnagyobb = bekertSzamok[i];
                }
            }
            Console.WriteLine("A legnagyobb szám: " + legnagyobb);
            //legkisebb
            int legkisebb = bekertSzamok[0];
            for (int i = 0; i < bekertSzamok.Count; i++) {
                if (bekertSzamok[i] < legkisebb) {
                    legkisebb = bekertSzamok[i];
                }
            }
            Console.WriteLine("A legkisebb szám: " + legkisebb);

            Console.ReadLine();
        }
    }
}
