using System;
namespace Uebung58_Angestellte_pbbgh20aba
{
    class Sekretaerin : Angestellter
    {
        private Angestellter arbeitetfuer;
        public Angestellter ArbeitetFuer { get => arbeitetfuer; set => arbeitetfuer = value; }


        public Sekretaerin(double grundgehalt, Angestellter arbeitetFuer) : base(grundgehalt)
        {
            ArbeitetFuer = arbeitetFuer;
        }


        public override string ToString()
        {
            return $"Sekretärin [grundgehalt={Grundgehalt}, arbeitetFür={ArbeitetFuer}]";
        }

    }
}
