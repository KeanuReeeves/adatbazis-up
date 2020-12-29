using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatbazis_up
{
    class Program
    {
        static List<Allatok> allat;
        static List<Gondozo> gondoz;
        public static void beolvas()
        {
            try
            {
                StreamReader sr = new StreamReader("Normalizalas.xlsx");
                string sor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    string[] st = sor.Split(';');
                    int id = 1;
                    Allatok a = new Allatok(id,Convert.ToInt32(st[2]),Convert.ToInt32(st[8]),
                        st[1],st[3],st[4],st[5],st[6],st[7],st[0],Convert.ToDateTime(st[9]),
                        Convert.ToDateTime(st[10]));
                    Gondozo g = new Gondozo(st[11], Convert.ToDateTime(st[12]),
                        Convert.ToDateTime(st[13]), Convert.ToInt32(st[14]));
                }
            }
            catch (FileNotFoundException)
            { 
            
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
