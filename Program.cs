using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND1_svarstykles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nYra 8 kamuoliukai ir vienas jų defektuotas, per du sverimus raskite kuris: ");

            //nedefektuotas kamuoliukas sveria 1 
            var kamuoliukas1 = 1;
            var kamuoliukas2 = 1;
            var kamuoliukas3 = 1;
            var kamuoliukas4 = 1;
            var kamuoliukas5 = 1;
            var kamuoliukas6 = 1;
            var kamuoliukas7 = 2;
            var kamuoliukas8 = 1;

            //pirmiausia, pasidalinam 8 kamuoliukus i 3 kruveles: (3, 3 ir 2)
            var pirmaKruvele = kamuoliukas1 + kamuoliukas2 + kamuoliukas3;
            var antraKruvele = kamuoliukas4 + kamuoliukas5 + kamuoliukas6;

            //lyginame pirma kruvele su antra kruvele (3 ir 3)
            if (pirmaKruvele != antraKruvele)
            {
                Console.WriteLine("\nPirmas sverimas: 1+2+3 kruvele buvo nelygi su 4+5+6");
                if (pirmaKruvele == 3)
                {
                    Console.WriteLine(",todel toliau yra daromas sverimas tarp 4+5+6");
                    if (kamuoliukas4 != kamuoliukas5)
                    {
                        Console.WriteLine("\nAntras sverimas: tarp 4 ir 5 kamuoliuku:");
                        if (kamuoliukas4 == 1)
                        {
                            Console.WriteLine("ir jie buvo nelygus: defektuotas rastas (5)");
                        }
                        else
                        {
                            Console.WriteLine("ir jie buvo nelygus: defektuotas rastas (4)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nAntras sverimas: tarp 4 ir 5 kamuoliuku - jie lygus: defektuotas rastas (6)");
                    }
                }
                else
                {
                    Console.WriteLine(",todel toliau yra daromas sverimas tarp 1+2+3");
                    if (kamuoliukas1 != kamuoliukas2)
                    {
                        Console.WriteLine("\nAntras sverimas: tarp 1 ir 2 kamuoliuku:");
                        if (kamuoliukas1 == 1)
                        {
                            Console.WriteLine("ir jie buvo nelygus: defektuotas rastas (2)");
                        }
                        else
                        {
                            Console.WriteLine("ir jie buvo nelygus: defektuotas rastas (1)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nAntras sverimas: tarp 1 ir 2 kamuoliuku - jie lygus: defektuotas rastas (3)");
                    }
                }
            }
            //jei pirmos dvi kruveles buvo lygios, tai tada defektuotas bus treciojoje (2 like kamuoliukai)
            else
            {
                Console.WriteLine("\nAntras sverimas:");
                if (kamuoliukas7 != kamuoliukas8)
                {
                    if (kamuoliukas7 == 1)
                    {
                        Console.WriteLine("\n7 buvo nelygus su 8: defektuotas rastas (8)");
                    }
                    else
                    {
                        Console.WriteLine("\n7 buvo nelygus su 8: defektuotas rastas (7)");
                    }
                }
                else
                {
                    Console.WriteLine("\nDefektuotu nera");
                }
            }
            Console.ReadLine();
        }
    }
}
