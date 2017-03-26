
namespace core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class relation
    {
      
        public int ID_TACHE { get; set; }
        public int TAC_ID_TACHE { get; set; }
        public Nullable<int> PREC { get; set; }
        public Nullable<int> SUCC { get; set; }
    
        public virtual taches taches { get; set; }
        public virtual taches taches1 { get; set; }
    }
}
