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
    }
}
