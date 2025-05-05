using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int augenzahl;

        public int Wuerfeln()
        {
            Random rnd = new Random();
            int zahl = rnd.Next(1, 7);

            return zahl;
        }

        public int Augenzahl
        {
            get { return augenzahl; }

        }
    }
}
