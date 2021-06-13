using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGym
{

    public class Smjena : Pristup_podacima.Smjena
    {
        public override string ToString()
        {
            return naziv.ToString();
        }
    }
}
