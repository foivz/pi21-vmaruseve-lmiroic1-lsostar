using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGym
{
    public class Trening:Pristup_podacima.Trening
    {
        public override string ToString()
        {
            return naziv.ToString();
        }
    }
}
