using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeri = new List<int>() { 1,7,3,4,5,6};
            List<Studente> studenti = new List<Studente>();
            studenti.Add(new Studente("Giuseppe", 20));
            studenti.Add(new Studente("Simona", 104));

            //Vogliamo ottenere i numeri pari dalla lista numeri
            List<int> pari = numeri.Where(n  => n%2==0).ToList();

            var nomi = studenti.Select(x=>x.Nome).ToList();
            var crescenti = studenti.OrderBy(x => x).ToList();
            foreach ( s in crescenti)
            { 
                Console.WriteLine(s);
            }
            
        }
    }
}
