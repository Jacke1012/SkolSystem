using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using SkolSystem.Klasser;

namespace SkolSystem
{
    [DataContract(IsReference = true)]
    public class LäraKonto : Konto
    {

        [DataMember]
        public string ämne;
        [DataMember]
        public List<Klass> klasser = new List<Klass>();

        public LäraKonto()
        {
        }

        public LäraKonto(string namn, string personNummer) : base(namn, personNummer)
        {
        }

        public override object Clone()
        {
            LäraKonto temp = new LäraKonto(namn, personNummer);
            temp.klasser = klasser;
            temp.ämne = ämne;
            return temp;
        }
    }
}
