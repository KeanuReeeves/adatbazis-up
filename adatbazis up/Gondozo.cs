using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatbazis_up
{
    class Gondozo
    {
        private string nev;
        private DateTime gondozas_kezdete, gondozas_vege;
        private int fizetesi_osztaly;

        public Gondozo(string nev, DateTime gondozas_kezdete, DateTime gondozas_vege, int fizetesi_osztaly)
        {
            this.nev = nev;
            this.gondozas_kezdete = gondozas_kezdete;
            this.gondozas_vege = gondozas_vege;
            this.fizetesi_osztaly = fizetesi_osztaly;
        }
        public string Nev { get => nev; }
        public DateTime Gondozas_kezdete { get => gondozas_kezdete; }
        public DateTime Gondozas_vege { get => gondozas_vege; }
        public int Fizetesi_osztaly { get => fizetesi_osztaly; }
    }
}
