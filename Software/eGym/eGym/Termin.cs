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
    
    public partial class Termin
    {
        public int ID { get; set; }
        public System.DateTime od { get; set; }
        public System.DateTime @do { get; set; }
        public int broj_mjesta { get; set; }
        public string zaposlenik_korisnickoIme { get; set; }
        public int trening_id { get; set; }
        public Nullable<int> vrstaVjezbe_id { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Trening Trening { get; set; }
        public virtual VrstaVjezbe VrstaVjezbe { get; set; }
    }
}
