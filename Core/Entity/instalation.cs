
namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class instalation
    {
        public instalation()
        {
            this.taches = new HashSet<taches>();
        }
    
        public int ID_INSTALATION { get; set; }
        public string DES_INSTA { get; set; }
        public string NUM_SERIE { get; set; }
        public string LIEU_INSTALATION { get; set; }
    
        public virtual ICollection<taches> taches { get; set; }
    }
}
