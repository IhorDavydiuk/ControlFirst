using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolnaja
{
    
    class Program
    {
        struct Gorod
        {
            public string Name;
            public int Naselen;
            public int Ploshad;


        }
        static void Main(string[] args)
        {
            Console.Write("Vvedite kolochestvo gorodov: ");
            int nom = int.Parse(Console.ReadLine());
            Gorod[] gor = new Gorod[nom];
            for (int i = 0; i < nom; i++)
            {
                
                Console.WriteLine("Vvedite name goroda ,naselenie i ploshad : ");
                Console.WriteLine("Gorod " + (i + 1));
                Console.Write("Name: ");
                gor[i].Name = Console.ReadLine();
                Console.Write("Naselenie: ");
                gor[i].Naselen = int.Parse(Console.ReadLine());
                Console.Write("Ploshad: ");
                gor[i].Ploshad = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < gor.Length; i++)
            {
                Console.Write("{0}={1},{2};",gor[i].Name,gor[i].Naselen,gor[i].Ploshad);
            }
            Console.WriteLine();
            
            
            Console.WriteLine();

            for (int i = 0; i < gor.Length; i++)
            {
                for (int j = 0; j < gor.Length - 1; j++)
                {
                    if (gor[j].Naselen > gor[j + 1].Naselen)
                    {
                        Gorod gor1 = gor[j];
                        gor[j] = gor[j + 1];
                        gor[j + 1] = gor1;
                    }
                }

            }
            Console.WriteLine("Most populated: " + gor[gor.Length - 1].Name + " " + "(" + gor[gor.Length - 1].Naselen +" people)");

            for (int i = 0; i < gor.Length; i++)
            {
                for (int j = 0; j < gor.Length - 1; j++)
                {
                    if (gor[j].Name.Length > gor[j + 1].Name.Length)
                    {
                        Gorod gor1 = gor[j];
                        gor[j] = gor[j + 1];
                        gor[j + 1] = gor1;
                    }
                }

            }


            Console.WriteLine("Longest name: " + gor[gor.Length - 1].Name + " " + "(" + gor[gor.Length - 1].Name.Length + " letters)");
            Console.WriteLine("Density: ");
            for (int i = 0; i < gor.Length; i++)
            {
                Console.WriteLine( @"{0} - {1:F}  ",gor[i].Name ,((double)gor[i].Naselen/gor[i].Ploshad) );
            }
        }
    }
}
