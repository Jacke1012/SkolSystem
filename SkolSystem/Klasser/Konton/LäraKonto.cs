using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkolSystem.Klasser;

namespace SkolSystem
{
    public class LäraKonto : Konto
    {
        public string ämne;
        public List<Klass> klasser = new List<Klass>();

        public LäraKonto(string namn, string personNummer) : base(namn, personNummer)
        {
        }
    }
}
