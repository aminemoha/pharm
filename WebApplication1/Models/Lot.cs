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
    
    public partial class Lot
    {
        public int Clelot { get; set; }
        public int Cleproduit { get; set; }
        public string Codelot { get; set; }
        public string Nlot { get; set; }
        public System.DateTime Dateexp { get; set; }
        public int Quantite { get; set; }
        public decimal Prixdachat { get; set; }
        public decimal Prixvente { get; set; }
        public decimal Prixgros { get; set; }
        public decimal Ppa { get; set; }
        public decimal Shp { get; set; }
    
        public virtual Produit Produit { get; set; }
    }
}
