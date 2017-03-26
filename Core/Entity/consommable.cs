
namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class consommable
    {
        public consommable()
        {
            this.tache_consommable = new HashSet<tache_consommable>();
        }
    
        public int ID_CONSOMMABLE { get; set; }
        public string DESIGNATION { get; set; }
    
        public virtual ICollection<tache_consommable> tache_consommable { get; set; }
    }
}
