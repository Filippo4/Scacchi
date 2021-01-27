using System;
using System.Collections.Generic;
using System.Text;

namespace Scacchi
{
    class Cella
    {
        public int Numero { get; private set;}
        public char Lettera { get; private set; }

        internal Cella(int n,char l)
        {
            Numero = n;
            Lettera = l;
        }
        public Colore Colore
        {
            get
            {
                bool numeropari = Numero % 2 == 0;
                bool letterapari = (Lettera-'A') % 2 == 0;
                if (numeropari == letterapari)
                    return Colore.Nero;
                else
                    return Colore.Bianco;
            }
        }
        public override string ToString()
        {
            return $"{Lettera}{Numero}";
        }
    }
}
