using System;
namespace Uebung58_Angestellte_pbbgh20aba
{
    class Verkaufer : Angestellter
    {
        private double provision;
        public double Provision { get => provision; set => provision = value; }

        public Verkaufer(double grundgehalt, double provision) : base(grundgehalt)
        {
            Provision = provision;
        }


        public override double BerechneMonatsgehalt() // Angestellter klasinda virtual yazdigim icin overridedan sonra otomatik olarak geldi
        {
            return base.BerechneMonatsgehalt() + provision;
        }


        public override string ToString()
        {
            return $"Verkaufer [Grundgehalt={Grundgehalt}, Provision={provision}]";
        }
    }
}
