using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolSystem.Klasser
{
    public class StudiePlan
    {
        public List<Kurs> kurser = new List<Kurs>();

        //public int antalPoäng => kurser.ForEach(x => antalPoäng += x.kurstyp.poäng);
        public int antalPoäng => kurser.Sum(x => x.kurstyp.poäng);

        public int maxPoäng;

        public void AddKurs(Kurs kurs)
        {
            if (antalPoäng < maxPoäng)
            {
                kurser.Add(kurs);
            }
        }
    }
}
