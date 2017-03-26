
namespace core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tache_materiel
    {
    
        public int ID_REUNION { get; set; }
       
        public int ID_TACHE { get; set; }
        public Nullable<int> QUANTITE { get; set; }
        public string TYPE { get; set; }
    
        public virtual materiel materiel { get; set; }
        public virtual taches taches { get; set; }
    }
}
