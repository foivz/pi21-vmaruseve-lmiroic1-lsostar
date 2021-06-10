using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGym
{
    public partial class SuplementView
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public decimal? Cijena { get; set; }
        public int Stanje { get; set; }
    }
}
