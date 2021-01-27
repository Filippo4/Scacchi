using System;

namespace Scacchi
{
    public class Scacchiera
    {
        public static Scacchiera Istanza { get; } = new Scacchiera();
        private Scacchiera()
        {
        }

        public List<Cella> GetCelle()
        {
            return;
        }
        public Cella GetCella(char l,int n)
        {
            string l_n = $"{l}{n}";

        }
    }
}
