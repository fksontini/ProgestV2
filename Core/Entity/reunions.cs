
namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class reunions
    {
        public reunions()
        {
            this.action = new HashSet<action>();
        }
    
        public int ID_REUNION { get; set; }
        public Nullable<int> ID_PROJET { get; set; }
        public string DESIGNATION { get; set; }
        public string NBR_PRESENT { get; set; }
        public string CODE_AFFAIRE { get; set; }
        public string TYPE { get; set; }
    
        public virtual ICollection<action> action { get; set; }
        public virtual projet projet { get; set; }
    }
}
