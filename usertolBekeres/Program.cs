using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usertolBekeres {
    class Program {
        static void Main(string[] args) {
            List<int> bekertSzamok = new List<int>();
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Kérem adjon meg egy számot!");
                bekertSzamok.Add( Convert.ToInt32(Console.ReadLine()));
            }
            int legnagyobb = bekertSzamok[0];
            for (int i = 0; i < bekertSzamok.Count; i++) {
                if (bekertSzamok[i]>legnagyobb) {
                    legnagyobb = bekertSzamok[i];
                }
            }
            Console.WriteLine("A legnagyobb szám: " + legnagyobb);


            Console.ReadLine();
        }
    }
}
