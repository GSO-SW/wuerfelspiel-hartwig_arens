using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;

        public Wuerfel()
        {
            this.anzahlSeiten = 6;
        }

        public Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;
        }

        public int AnzahlSeiten
        {
            get
            {
                return anzahlSeiten;
            }
        }

        public int Wuerfeln()
        {
            Random result = new Random();
            return result.Next(1, anzahlSeiten);
        }
    }
}
