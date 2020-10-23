using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SkolSystem
{
    [DataContract(IsReference = true)]
    public abstract class Konto : ICloneable
    {
        [DataMember]
        public string namn;
        [DataMember]
        public string personNummer;
        [DataMember]
        public string password;

        protected Konto()
        {
        }

        protected Konto(string namn, string personNummer)
        {
            this.namn = namn;
            this.personNummer = personNummer;
        }

        public virtual object Clone()
        {
            return null;
        }
    }
}
