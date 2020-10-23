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
        protected Resultat resultat;
        public LäraKonto lärare;
        public Klass klass;

        public Kurs(KursTyp kurstyp, LäraKonto lärare)
        {
            this.kurstyp = kurstyp;
            this.lärare = lärare;
        }
    }
}
