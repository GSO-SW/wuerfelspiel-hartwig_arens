using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;
        int letztesErgebnis;

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

        public int LetztesErgebnis
        {
            get
            {
                return letztesErgebnis;
            }
        }

        public int Wuerfeln()
        {
            Random result = new Random();
            return result.Next(1, anzahlSeiten);
        }
    }
}
