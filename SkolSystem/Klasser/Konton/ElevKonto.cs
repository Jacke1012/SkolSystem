using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using SkolSystem.Forms;
using SkolSystem.Klasser;

namespace SkolSystem
{
    [DataContract(IsReference = true)]
    public class ElevKonto : Konto
    {
        [DataMember]
        public StudiePlan studiePlan;

        public ElevKonto(string namn, string personNummer) : base(namn, personNummer)
        {
            studiePlan = new StudiePlan();
        }

        public ElevKonto()
        {
        }

        public void OpenProfilePage()
        {
            ElevProfile elevProfile = new ElevProfile(this);
            elevProfile.Show();
        }
        public override object Clone()
        {
            ElevKonto temp = new ElevKonto(namn, personNummer);
            temp.studiePlan = studiePlan;
            return temp;
        }

        public override string ToString()
        {
            return $"{namn}, {personNummer}";
        }
    }
}
