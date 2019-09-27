using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AukcioProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Festmeny> festmenyek = new List<Festmeny>();
            festmenyek.Add(new Festmeny("esos ido", "Britniszpirsz", "stilusos"));
            festmenyek.Add(new Festmeny("napos ido", "Lakatos Brendon", "kalácskép"));

            Console.WriteLine("Adjon meg egy darabszámot:");
            int darabszam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja eg a festmény adatait: (Cím, Festő, Stílus)");
            for (int i = 0; i < darabszam; i++)
            {
                string cim = Console.ReadLine();
                string festo = Console.ReadLine();
                string stilus = Console.ReadLine();
                festmenyek.Add(new Festmeny(cim,festo,stilus));
            }
            




            Console.ReadKey();
        }
    }
}
