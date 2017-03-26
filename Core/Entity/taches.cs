namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class taches
    {
        public taches()
        {
            this.doc_inspection = new HashSet<doc_inspection>();
            this.equipe_tache = new HashSet<equipe_tache>();
            this.relation = new HashSet<relation>();
            this.relation1 = new HashSet<relation>();
            this.tache_consommable = new HashSet<tache_consommable>();
            this.tache_logistique = new HashSet<tache_logistique>();
            this.tache_materiel = new HashSet<tache_materiel>();
        }
    
        public int ID_TACHE { get; set; }
        public Nullable<int> ID_MODULE { get; set; }
        public Nullable<int> ID_SPRINT { get; set; }
        public int ID_INSTALATION { get; set; }
        public string NOM_TACHE { get; set; }
        public string DESCRIPTON { get; set; }
        public string DUREER_MOYENNE { get; set; }
        public string STATUT_TACHE { get; set; }
        public Nullable<System.DateTime> DATE_DEBUT_ESTIM { get; set; }
        public Nullable<System.DateTime> DATE_DEBUT_REEL { get; set; }
        public Nullable<System.DateTime> DATE_FIN_REEL { get; set; }
    
        public virtual ICollection<doc_inspection> doc_inspection { get; set; }
        public virtual ICollection<equipe_tache> equipe_tache { get; set; }
        public virtual instalation instalation { get; set; }
        public virtual modules modules { get; set; }
        public virtual ICollection<relation> relation { get; set; }
        public virtual ICollection<relation> relation1 { get; set; }
        public virtual sprint sprint { get; set; }
        public virtual ICollection<tache_consommable> tache_consommable { get; set; }
        public virtual ICollection<tache_logistique> tache_logistique { get; set; }
        public virtual ICollection<tache_materiel> tache_materiel { get; set; }
    }
}
