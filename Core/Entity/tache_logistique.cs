
namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class tache_logistique
    {
        public int ID_LOGISTIQUE { get; set; }
        public int ID_TACHE { get; set; }
        public Nullable<int> QUANTITE { get; set; }
        public string TYPE { get; set; }
    
        public virtual vehicule vehicule { get; set; }
        public virtual taches taches { get; set; }
    }
}
