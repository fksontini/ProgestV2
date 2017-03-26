
namespace core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class consommable
    {
        public consommable()
        {
            this.tache_consommable = new HashSet<tache_consommable>();
        }
        [Key]
        public int ID_CONSOMMABLE { get; set; }
        public string DESIGNATION { get; set; }
    
        public virtual ICollection<tache_consommable> tache_consommable { get; set; }
    }
}
