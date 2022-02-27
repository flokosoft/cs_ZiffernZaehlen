using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_ZiffernZaehlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool NeueEingabe = true;
            while (NeueEingabe)
            {
                Console.Write("Bitte gebe eine Zahl ein, zu welcher gezählt werden soll: ");
                double Eingabe;
                if (!double.TryParse(Console.ReadLine(), out Eingabe))
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.ReadLine();
                }
                else
                {
                    DateTime StartZeit = DateTime.Now;
                    double x = 1;
                    double GezaehlteZiffern = 0;
                    while (x <= Eingabe)
                    {

                        Console.WriteLine("Ich bin bei {0}", x);
                        string GezaehlteZiffernTemp = x.ToString();
                        double GezaehlteZiffernLaenge = Convert.ToDouble(GezaehlteZiffernTemp.Length);
                        GezaehlteZiffern += GezaehlteZiffernLaenge;

                        if (x == Eingabe)
                        {
                            DateTime EndZeit = DateTime.Now;
                            TimeSpan GemmesseneZeit = EndZeit - StartZeit;
                            Console.WriteLine("Es wurde bis {0} gezählt.\nInsgesamt habe ich {1} Ziffern geschrieben!", Eingabe, GezaehlteZiffern);
                            Console.WriteLine("Dafür wurden: {0} (h:m:s) benötigt.", GemmesseneZeit);
                            Console.Write("Neue Eingabe vornehmen? j/n: ");
                            string NeueRunde = Console.ReadLine();
                            if(NeueRunde == "y" || NeueRunde == "j")
                            {
                                NeueEingabe = true;
                            }
                            else
                            {
                                NeueEingabe = false;
                            }
                        }
                        x++;

                    }
                }
            }
        }
    }
}
