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
            set { gesichert = value; }
        }

        public int Wuerfeln()
        {
            if(gesichert != true)
            {
                Random rnd = new Random();
                Augenzahl = rnd.Next(1, 7);

                return augenzahl;
            }
            else
            {
                return Augenzahl;
            }
        }

        public int WuerfelDreiMal()
        {
            int letzterWurf = 0;
            

            for (int i = 0; i < 2; i++)
            {
                if(!Gesichert)
                {
                    letzterWurf = Wuerfeln();
                }
                else
                {
                    break;
                }
            }
            return letzterWurf;
        }
    }
}
       

    

