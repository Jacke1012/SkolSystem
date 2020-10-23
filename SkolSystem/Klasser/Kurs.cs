using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolSystem.Klasser
{
    public class Kurs
    {
        public KursTyp kurstyp;
        public Resultat resultat;
        public LäraKonto lärare;
        public Klass klass;
        public string kursInfo => $"{kurstyp.kursNamn}: {kurstyp.kursInfo}";

        public Kurs(KursTyp kurstyp, LäraKonto lärare)
        {
            this.kurstyp = kurstyp;
            this.lärare = lärare;
            resultat = new Resultat();
        }

        public Kurs()
        {
        }

        public override string ToString()
        {
            return $"{kurstyp}";
        }
    }
}
