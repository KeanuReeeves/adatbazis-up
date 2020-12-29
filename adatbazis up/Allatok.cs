using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatbazis_up
{
    class Allatok
    {
        private int id, lab,cellaSzam;
        private string nev, neme, szine, erosseg, gyengeseg, elelem,faj;
        private DateTime szulIdo, halalIdo;

        public Allatok(int id, int lab,int cellaSzam, string nev, string neme, 
            string szine, string erosseg, string gyengeseg, string elelem,string faj, 
            DateTime szulIdo, DateTime halalIdo)
        {
            this.id = id;
            this.lab = lab;
            this.cellaSzam = cellaSzam;
            this.nev = nev;
            this.neme = neme;
            this.szine = szine;
            this.erosseg = erosseg;
            this.gyengeseg = gyengeseg;
            this.elelem = elelem;
            this.faj = faj;
            this.szulIdo = szulIdo;
            this.halalIdo = halalIdo;
        }

        public int Id { get => id;}
        public int Lab { get => lab;}
        public int CellaSzam { get => cellaSzam; }
        public string Nev { get => nev;}
        public string Neme { get => neme;}
        public string Szine { get => szine;}
        public string Erosseg { get => erosseg;}
        public string Gyengeseg { get => gyengeseg;}
        public string Elelem { get => elelem;}
        public string Faj { get => faj; }
        public DateTime SzulIdo { get => szulIdo;}
        public DateTime HalalIdo { get => halalIdo;}
    }
}
