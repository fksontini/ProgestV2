
namespace core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class equipe_tache
    {
      
        public int ID_USER { get; set; }
   
        public int ID_TACHE { get; set; }
        public string QUALIFICATION { get; set; }
        public string TYPE_AFFECTATION { get; set; }
    
        public virtual utilisateur utilisateur { get; set; }
        public virtual taches taches { get; set; }
    }
}
