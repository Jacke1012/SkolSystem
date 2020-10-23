using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolSystem.Klasser
{
    public class KursTyp
    {
        public string kursNamn;
        public string kursInfo;
        public int poäng;

        public KursTyp()
        {
        }



        public KursTyp(string kursNamn, string kursInfo, int poäng)
        {
            this.kursNamn = kursNamn;
            this.kursInfo = kursInfo;
            this.poäng = poäng;
        }

        public override string ToString()
        {
            return kursNamn;
        }
    }
}
