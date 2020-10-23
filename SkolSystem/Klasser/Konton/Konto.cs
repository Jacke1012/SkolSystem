using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolSystem
{
    public abstract class Konto
    {
        public string namn;
        public string personNummer;

        protected Konto(string namn, string personNummer)
        {
            this.namn = namn;
            this.personNummer = personNummer;
        }
    }
}
