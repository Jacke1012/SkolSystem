using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkolSystem.Klasser;

namespace SkolSystem
{
    public class ElevKonto : Konto
    {
        public StudiePlan studiePlan;

        public ElevKonto(string namn, string personNummer) : base(namn, personNummer)
        {
            studiePlan = new StudiePlan();
        }

        public void OpenProfilePage()
        {

        }
    }
}
