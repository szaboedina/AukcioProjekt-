using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AukcioProjekt
{
    class Festmeny
    {
        string cim;
        string festo;
        string stilus;
        int licitekSzama;
        int legmagasabbLicit;
        DateTime legutolsoLicitIdeje;
        bool elkelt;
        DateTime now = DateTime.Now;

        public Festmeny(string cim, string festo, string stilus)
        {
            this.cim = cim;
            this.festo = festo;
            this.stilus = stilus;
            this.licitekSzama = 0;
            this.legmagasabbLicit = 0;
            this.elkelt = false;
        }

        public string Cim { get => cim; set => cim = value; }
        public string Festo { get => festo; set => festo = value; }
        public string Stilus { get => stilus; set => stilus = value; }
        public int LicitekSzama { get => licitekSzama; set => licitekSzama = value; }
        public int LegmagasabbLicit { get => legmagasabbLicit; set => legmagasabbLicit = value; }
        public DateTime LegutolsoLicitIdeje { get => legutolsoLicitIdeje; set => legutolsoLicitIdeje = value; }
        public bool Elkelt { get => elkelt; set => elkelt = value; }

        



        public override string ToString()
        {
            if (elkelt)
            {
                return festo + ": " + cim + "(" + stilus + ")\nelkelt\n" + legmagasabbLicit + "$ - " + legutolsoLicitIdeje + "(összesen: " + licitekSzama + " db)";

            }
            else
            {
                return festo + ": " + cim + "(" + stilus + ")\n" + legmagasabbLicit + "$ - " + legutolsoLicitIdeje + "(összesen: " + licitekSzama + " db)";

            }
        }


        public void Licit()
        {
            if (elkelt)
            {
                Console.WriteLine("Már elkelt.");
            }
            else if (licitekSzama==0)
            {
                legmagasabbLicit += 100;
                licitekSzama++;
                legutolsoLicitIdeje = now;
            }
            else
            {
                legmagasabbLicit+=legmagasabbLicit / 10;
                licitekSzama++;
                legutolsoLicitIdeje = now;

            }
        }
        public void Licit(int mertek)
        {
            if (mertek>9 && mertek<101)
            {
                legmagasabbLicit = legmagasabbLicit+(legmagasabbLicit / mertek);
                licitekSzama++;
                legutolsoLicitIdeje = now;
            }
            else
            {
                Console.WriteLine("Hibás paraméter");
            }
        }


    }
}
