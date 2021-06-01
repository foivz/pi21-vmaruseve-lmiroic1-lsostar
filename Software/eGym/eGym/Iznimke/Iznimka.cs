using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGym.Iznimke
{
    public class Iznimka : ApplicationException
    {
        public string poruka { get; set; }
        public Iznimka (string p)
        {
            poruka = p;
        }
    }
}
