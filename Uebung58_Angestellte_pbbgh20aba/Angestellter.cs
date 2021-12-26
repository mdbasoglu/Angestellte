using System;
namespace Uebung58_Angestellte_pbbgh20aba
{
    class Angestellter
    {
        private double grundgehalt;
        public double Grundgehalt { get => grundgehalt; set => grundgehalt = value; }

        public Angestellter(double grundgehalt)
        {
            Grundgehalt = grundgehalt;
        }

        public virtual double BerechneMonatsgehalt()
        {
            return Grundgehalt;
        }

        public double Berechnejahresgehalt()
        {
            return BerechneMonatsgehalt() * 12;

        }

        public override string ToString()
        {
            return $"Angestellter[ Grundgehalt={Grundgehalt} ]";
        }
    }
}
