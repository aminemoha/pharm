//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit()
        {
            this.Lots = new HashSet<Lot>();
        }
    
        public int Cleproduit { get; set; }
        public string Code { get; set; }
        public string Reference { get; set; }
        public string Designation { get; set; }
        public string Remarque { get; set; }
        public string Fulldesignation { get; set; }
        public double Quantitealerte { get; set; }
        public double Quantitemax { get; set; }
        public string Unite { get; set; }
        public decimal Pmp { get; set; }
        public decimal Dernierprixdachat { get; set; }
        public decimal Prixdachatmin { get; set; }
        public decimal Prixdachatmax { get; set; }
        public decimal Prixdevente { get; set; }
        public decimal Prixdeventemin { get; set; }
        public decimal Prixdeventemax { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lot> Lots { get; set; }
    }
}
