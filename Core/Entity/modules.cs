
namespace core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class modules
    {
        public modules()
        {
            this.taches = new HashSet<taches>();
        }
        [Key]
        public int ID_MODULE { get; set; }
        public Nullable<int> ID_PROJET { get; set; }
        public string DESIGNATION { get; set; }
        public string NBREPOINT_ { get; set; }
        public string STATUT { get; set; }
        public string AVANCEMENT { get; set; }
    
        public virtual ICollection<taches> taches { get; set; }
        public virtual projet projet { get; set; }
    }
}
