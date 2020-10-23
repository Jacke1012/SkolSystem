using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolSystem.Klasser
{
    public class Klass
    {
        protected List<ElevKonto> elever = new List<ElevKonto>();
        public LäraKonto lärare;

        public List<ElevKonto> GetElever()
        {
            return elever;
        }
    }
}
