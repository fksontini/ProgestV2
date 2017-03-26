
namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class materiel
    {
        public materiel()
        {
            this.tache_materiel = new HashSet<tache_materiel>();
        }
    
        public int ID_REUNION { get; set; }
        public string DESIGNATION { get; set; }
    
        public virtual ICollection<tache_materiel> tache_materiel { get; set; }
    }
}
