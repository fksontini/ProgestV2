
namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class utilisateur
    {
        public utilisateur()
        {
            this.action = new HashSet<action>();
            this.equipe_tache = new HashSet<equipe_tache>();
            this.mail = new HashSet<mail>();
            this.mail1 = new HashSet<mail>();
            this.projet = new HashSet<projet>();
        }
    
        public int ID_USER { get; set; }
        public int ID_ROLE { get; set; }
        public string MATRICULE { get; set; }
        public string PRENOM { get; set; }
        public string STATUT { get; set; }
        public string PASSWORD { get; set; }
        public string NOM { get; set; }
    
        public virtual ICollection<action> action { get; set; }
        public virtual ICollection<equipe_tache> equipe_tache { get; set; }
        public virtual ICollection<mail> mail { get; set; }
        public virtual ICollection<mail> mail1 { get; set; }
        public virtual ICollection<projet> projet { get; set; }
        public virtual roles roles { get; set; }
    }
}
