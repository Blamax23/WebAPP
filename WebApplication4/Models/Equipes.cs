//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipes()
        {
            this.Joueurs = new HashSet<Joueurs>();
            this.Matchs = new HashSet<Matchs>();
        }
    
        public int ID_Equipe { get; set; }
        public string NOM_Equipe { get; set; }
        public string LIB_Equipe { get; set; }
        public int NOMBRE_VICTOIRES_Equipe { get; set; }
        public int NOMBRE_DEFAITES_Equipe { get; set; }
        public string CONFERENCE_Equipe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Joueurs> Joueurs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matchs> Matchs { get; set; }
    }
}