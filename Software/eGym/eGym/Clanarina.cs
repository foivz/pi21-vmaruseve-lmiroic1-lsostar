//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eGym
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clanarina
    {
        public int ID { get; set; }
        public System.DateTime vrijedi_od { get; set; }
        public System.DateTime vrijedi_do { get; set; }
        public int vrsta_id { get; set; }
        public string korisnik_korisnickoIme { get; set; }
        public bool placeno { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual VrstaClanarine VrstaClanarine { get; set; }
    }
}