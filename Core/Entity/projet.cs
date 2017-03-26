
namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class projet
    {
        public projet()
        {
            this.doc_projet = new HashSet<doc_projet>();
            this.modules = new HashSet<modules>();
            this.reunions = new HashSet<reunions>();
        }
    
        public int ID_PROJET { get; set; }
        public string MATRICULE { get; set; }
        public int ID_USER { get; set; }
        public Nullable<int> ID_SERVICE { get; set; }
        public string INTITULE { get; set; }
        public string DESECRIPTION { get; set; }
        public string CODE_AFFAIRE { get; set; }
        public string LIEU { get; set; }
        public string SERVICE { get; set; }
        public Nullable<System.DateTime> DATE_DEBUT { get; set; }
        public Nullable<System.DateTime> DATE_ESTIMER_FIN { get; set; }
        public string DUREER_ESTIMER { get; set; }
        public string COUT { get; set; }
    
        public virtual client client { get; set; }
        public virtual ICollection<doc_projet> doc_projet { get; set; }
        public virtual ICollection<modules> modules { get; set; }
        public virtual service service1 { get; set; }
        public virtual ICollection<reunions> reunions { get; set; }
        public virtual utilisateur utilisateur { get; set; }

       
    }
}
