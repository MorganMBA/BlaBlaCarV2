//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlaBlaCarV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class MESSAGERIE
    {
        public int ID_MESSAGERIE { get; set; }
        public int ID_EXPEDITEUR { get; set; }
        public int ID_DESTINATAIRE { get; set; }
        public string SUJET { get; set; }
        public string LIB_MESSAGE { get; set; }
        public byte[] DT_TIMESTAMP { get; set; }
        public string STATUT { get; set; }
    
        public virtual AUTHENTIFICATION AUTHENTIFICATION { get; set; }
        public virtual AUTHENTIFICATION AUTHENTIFICATION1 { get; set; }
    }
}