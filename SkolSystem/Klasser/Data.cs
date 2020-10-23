using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SkolSystem.Klasser
{
    [DataContract]
    [KnownType(typeof(LäraKonto))]
    [KnownType(typeof(ElevKonto))]
    [KnownType(typeof(Konto))]
    [KnownType(typeof(Klass))]
    [KnownType(typeof(StudiePlan))]
    [KnownType(typeof(Resultat))]

    public class Data
    {
        [DataMember]
        public List<Konto> allaKonton = new List<Konto>();
        public List<KursTyp> kursTyper = new List<KursTyp>();
    }
}
