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
    
    public partial class artikl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public artikl()
        {
            this.rezervacija = new HashSet<rezervacija>();
            this.stavka_racuna = new HashSet<stavka_racuna>();
        }
    
        public int artikl_id { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public Nullable<double> cijena { get; set; }
        public Nullable<int> kolicina_na_skladistu { get; set; }
        public int dobavljac_id { get; set; }
    
        public virtual dobavljac dobavljac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rezervacija> rezervacija { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavka_racuna> stavka_racuna { get; set; }
    }
}
