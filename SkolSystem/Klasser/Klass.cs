using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SkolSystem.Klasser
{
    [DataContract]
    public class Klass
    {
        [DataMember]
        public KursTyp kursTyp;
        [DataMember]
        protected List<ElevKonto> elever = new List<ElevKonto>();
        [DataMember]
        public LäraKonto lärare;
        [DataMember]
        public string klassNamn;
        public string kursInfo => $"{kursTyp.kursNamn}: {kursTyp.kursInfo}";


        public Klass(LäraKonto lärare, List<ElevKonto> elever, KursTyp kursTyp,string klassNamn)
        {
            this.elever = elever;
            this.lärare = lärare;
            this.kursTyp = kursTyp;
            this.klassNamn = klassNamn;

            foreach (ElevKonto item in elever)
            {
                item.studiePlan.AddKurs(new Kurs(kursTyp, lärare));
            }
        }

        public List<ElevKonto> GetElever()
        {
            return elever;
        }

        public override string ToString()
        {
            return $"{kursTyp}";
        }
    }
}
