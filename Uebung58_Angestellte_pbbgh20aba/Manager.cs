using System;
namespace Uebung58_Angestellte_pbbgh20aba
{
    class Manager : Angestellter
    {
        private double zulage;
        public double Zulage { get => zulage; set => zulage = value; }

        private Angestellter[] personalverantwortung;
        public Angestellter[] Personalverantwortung { get => personalverantwortung; set => personalverantwortung = value; }

        private bool mitgliedDerGeschaeftsleitung;
        public bool MitgliedDerGeschaeftsleitung { get => mitgliedDerGeschaeftsleitung; set => mitgliedDerGeschaeftsleitung = value; }

        private int jahreFirmenzugehoerigkeit;
        public int JahreFirmenzugoeherigkeit { get => jahreFirmenzugehoerigkeit; set => jahreFirmenzugehoerigkeit = value; }



        public Manager(double grundgehalt,
                        double zulage,
                        Angestellter[] personalverantwortung,
                        bool mitgliedDerGeschaeftsleitung,
                        int jahreFirmenzugoeherigkeit)
                        : base(grundgehalt)
        {
            Zulage = zulage;
            Personalverantwortung = personalverantwortung;
            MitgliedDerGeschaeftsleitung = mitgliedDerGeschaeftsleitung;
            JahreFirmenzugoeherigkeit = jahreFirmenzugoeherigkeit;

        }

        public override double BerechneMonatsgehalt()
        {
            double gesamtzulage = 0;

            if (mitgliedDerGeschaeftsleitung == true) //yada true olmadanda yazabilirsin
            {
                gesamtzulage += zulage;
            }
            if (personalverantwortung.Length > 12)
            {
                gesamtzulage += zulage;
            }
            if (jahreFirmenzugehoerigkeit > 10)
            {
                gesamtzulage += zulage;
            }

            return base.BerechneMonatsgehalt() + gesamtzulage;
        }

        public override string ToString()
        {
            return $"Manager[Zulage={Zulage}, " +
                    $"Personalverantwortung={Personalverantwortung}, " +
                    $"MitgliedDerGeschaeftsleitung={MitgliedDerGeschaeftsleitung}," +
                    $"JahreFirmenzugoeherigkeit={JahreFirmenzugoeherigkeit}]";
        }


    }
}
