//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3_GSB_BalemrogV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Region()
        {
            this.Visiteur1 = new HashSet<Visiteur>();
        }
    
        public int idRegion { get; set; }
        public string libRegion { get; set; }
        public string idVisiteur { get; set; }
        public int idSecteur { get; set; }
    
        public virtual Secteur Secteur { get; set; }
        public virtual Visiteur Visiteur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visiteur> Visiteur1 { get; set; }
    }
}
