//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class servis_log
    {
        public int id { get; set; }
        public int servis_id { get; set; }
        public string opis_promjene { get; set; }
        public Nullable<double> cijena_promjene { get; set; }
        public Nullable<System.DateTime> datum_promjene { get; set; }
        public int zaposlenik_id { get; set; }
        public string status { get; set; }
    
        public virtual korisnik korisnik { get; set; }
        public virtual radni_nalog_servisa radni_nalog_servisa { get; set; }
    }
}
