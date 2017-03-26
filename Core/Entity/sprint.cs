
namespace core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class sprint
    {
        public sprint()
        {
            this.taches = new HashSet<taches>();
        }
        [Key]
        public int ID_SPRINT { get; set; }
        public Nullable<System.DateTime> DATE_DEBUT { get; set; }
        public Nullable<System.DateTime> DATE_FIN { get; set; }
        public string DUREER_ESTIMER { get; set; }
        public string ETAT { get; set; }
    
        public virtual ICollection<taches> taches { get; set; }
    }
}
