using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1produljenie
{
    class Program
    {
        static double vremevsekundi(double chas,double min,double sec)
        {
            double vsek = chas * 3600 + min * 60 + sec;
            return vsek;
        }
        static double vremetovchasove(double chas,double min,double sec)
        {
            double vhours = sec / 3600 + min / 60 + chas;
            return vhours;
        }
        static double metrivmili(double metri)
        {
            double metrivmili = metri / 1609.344;
            return metrivmili;
        }
        static double metrivkilo(double metri)
        {
            double metrikilometri = metri / 1000;
            return metrikilometri;
        }
        static void Main(string[] args)
        {
            double metar = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double sek = double.Parse(Console.ReadLine());
   
            Console.WriteLine("vremeto v sekundi = " + vremevsekundi(hours , minutes , sek));
            Console.WriteLine("vremeto v chasove = " + vremetovchasove(hours , minutes , sek));
           
            Console.WriteLine("metri v mili = " + metrivmili(metar));
            
            Console.WriteLine("metri v kilometri = " + metrivkilo(metar));
            double ms = 0;
            double kmh = 0;
            double milh = 0;
            ms = metar / vremevsekundi(hours,minutes,sek);
            kmh = metrivkilo(metar) / vremevsekundi(hours, minutes, sek);
            milh = metrivmili(metar) / vremevsekundi(hours, minutes, sek); 
            Console.WriteLine("m/s = " + ms);
            Console.WriteLine("km/h = " + kmh);
            Console.WriteLine("mi/h = " + milh);
        }
    }
}
