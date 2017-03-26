
namespace core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class vehicule
    {
        public vehicule()
        {
            this.tache_logistique = new HashSet<tache_logistique>();
        }
        [Key]
        public int ID_LOGISTIQUE { get; set; }
        public string NOM { get; set; }
    
        public virtual ICollection<tache_logistique> tache_logistique { get; set; }
    }
}
