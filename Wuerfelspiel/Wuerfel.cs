using System;
using System.Security.Policy;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int augenzahl;
        private bool gesichert;
        public int Augenzahl
        {
            get { return augenzahl; }
            set { augenzahl = value; }
        }

        public bool Gesichert
        {
            get { return gesichert; }
            set {  gesichert = value; }
        }


        public int Wuerfeln()
        {
            if (gesichert != true)
            {
                Random rnd = new Random();
                Augenzahl = rnd.Next(1, 7);

                return Augenzahl;
            }
            else
            {
                return Augenzahl;
            }

        }        
    }
}
