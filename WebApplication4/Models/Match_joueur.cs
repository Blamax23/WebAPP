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
    
    public partial class Match_joueur
    {
        public int ID_Match { get; set; }
        public int ID_Joueur { get; set; }
        public int ScoreJoueur { get; set; }
    
        public virtual Joueurs Joueurs { get; set; }
        public virtual Matchs Matchs { get; set; }
    }
}
