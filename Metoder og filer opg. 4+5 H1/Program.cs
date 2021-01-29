using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metoder_og_filer_opg._4_5_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 4 Opret en mappe:

            Directory.CreateDirectory(@".\Droids");

            //Opgave 5: Slet en mappe rekursivt

            File.WriteAllText(@".\Droids\R2D2.txt", "beep bop"); //opretter først en fil med tekst så der er noget at slette rekursivt
            Directory.Delete(@".\Droids", true);

        }
    }
}
