using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGym
{
    public class Suplement:Pristup_podacima.Suplement
    {
        public override string ToString()
        {
            return naziv.ToString();
        }
    }
}
