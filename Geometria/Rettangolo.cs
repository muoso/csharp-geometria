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


        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
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



    }
}
