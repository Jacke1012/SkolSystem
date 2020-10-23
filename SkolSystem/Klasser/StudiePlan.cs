using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SkolSystem.Klasser
{
    [DataContract(IsReference = true)]
    public class StudiePlan
    {
        [DataMember]
        public List<Kurs> kurser = new List<Kurs>();

        //public int antalPoäng => kurser.ForEach(x => antalPoäng += x.kurstyp.poäng);
        public int antalPoäng => kurser.Sum(x => x.kurstyp.poäng);
        [DataMember]
        public int maxPoäng;

        public StudiePlan()
        {
        }

        public void AddKurs(Kurs kurs)
        {
            kurser.Add(kurs);
            //if (antalPoäng < maxPoäng)
            //{
            //    kurser.Add(kurs);
            //}
        }
    }
}
