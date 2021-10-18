using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Credit
{
    public class Credit
    {
        private int capital;
        private string duree;
        private int taux;
        private int mensualite;

        public Credit()
        {
            taux = 0;
            duree = "Durée";
            mensualite = 0;
        }

        public Credit(int taux, string duree, int mensualite)
        {
            this.taux = taux;
            this.duree = duree;
            this.mensualite = mensualite;
        }

        public int getMensualite()
        {
            return mensualite;
        }

        public void setMensualite(int mensualite)
        {
            this.mensualite = mensualite;
        }

        public int getTaux()
        {
            return taux;
        }

        public void setTaux(int taux)
        {
            this.taux = taux;
        }

        public string getDuree()
        {
            return duree;
        }

        public void setDuree(string duree)
        {
            this.duree = duree;
        }

        public int getCapital()
        {
            return capital;
        }

        public void setCapital(int capital)
        {
            this.capital = capital;
        }

        public int CalculMensualite()
        {
            mensualite = (capital * taux) / (1 - (1 + taux)); Math.Pow(duree);
            return mensualite;
        }
    }
}
