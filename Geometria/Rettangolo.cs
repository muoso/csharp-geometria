using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        private int baseRettangolo;
        private int altezzaRettangolo;
        private string nomeRettangolo;


        public Rettangolo(int baseRettangolo, int altezzaRettangolo, string nomeRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
            this.nomeRettangolo=nomeRettangolo;
        }

        public int calcolaArea()
        {
            return baseRettangolo * altezzaRettangolo;
        }

        public int calcolaPerimetro()
        {
            int perimetro = (baseRettangolo * 2) + (altezzaRettangolo * 2);
            return perimetro;
        }

        public void stampaRettangolo()
        {
            Console.WriteLine($"--{nomeRettangolo}--");
            Console.WriteLine($"base: {baseRettangolo} cm");
            Console.WriteLine($"altezza: {altezzaRettangolo} cm");
            Console.WriteLine($"perimetro: {calcolaPerimetro()} cm");
            Console.WriteLine($"area: {calcolaArea()} cm2");
        }

        public void disegnaRettangolo()
        {
            for (int i = 0; i < altezzaRettangolo; i++)
            {
                if(i==0 || i== altezzaRettangolo - 1)
                {
                    string rectangleBaseDashes = "";
                    for (int x = 0; x < baseRettangolo; x++)
                    {
                        rectangleBaseDashes += "-";
                    }
                    Console.WriteLine(rectangleBaseDashes);
                } else
                {
                    string rectangleBodySpaces = "";
                    for (int y = 0; y < baseRettangolo - 2; y++)
                    {
                        rectangleBodySpaces += " "; 
                    }
                    Console.WriteLine($"|{rectangleBodySpaces}|");
                }
                
            }
            
        }



    }
}
