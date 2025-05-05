using System;
using System.Security.Policy;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int augenzahl;

        public int Augenzahl
        {
            get { return augenzahl; }
        }


        public int Wuerfeln()
        {
            Random rnd = new Random();
            int zahl = rnd.Next(1, 7);

            return zahl;
        }
    }
}
