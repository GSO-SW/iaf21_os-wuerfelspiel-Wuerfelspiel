using System;
using System.Security.Policy;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int augenzahl;

<<<<<<< HEAD
        public int Augenzahl
        {
            get { return augenzahl; }
        }

            
=======
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
>>>>>>> 6d58e43534bdba0da8993fc9af02f77ef7c523df
    }
}
