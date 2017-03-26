
namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class tache_consommable
    {
        public int ID_CONSOMMABLE { get; set; }
        public int ID_TACHE { get; set; }
        public Nullable<int> QUANTITE { get; set; }
        public string TYPE { get; set; }
    
        public virtual consommable consommable { get; set; }
        public virtual taches taches { get; set; }
    }
}
