
namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class mail
    {
        public int ID_USER { get; set; }
        public int UTI_ID_USER { get; set; }
        public int ID_MSG { get; set; }
        public string SUJET { get; set; }
        public Nullable<int> DESTINATAIRE { get; set; }
        public Nullable<int> EMETTEUR { get; set; }
        public Nullable<System.DateTime> DATE_D_ENVOI { get; set; }
    
        public virtual utilisateur utilisateur { get; set; }
        public virtual utilisateur utilisateur1 { get; set; }
    }
}
