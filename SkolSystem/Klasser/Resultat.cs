using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SkolSystem.Klasser
{
    [DataContract]
    public class Resultat
    {
        public enum Stage { pågående, färdig };
        public enum Betyg { N_A=-1,F,E,D,C,B,A};

        [DataMember]
        public Betyg betygBokstav;
        [DataMember]
        public Stage stage;

        public Resultat()
        {
            betygBokstav = Betyg.F;
            stage = Stage.pågående;
        }
    }
}
