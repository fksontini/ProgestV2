
namespace core
{
    using System;
    using System.Collections.Generic;

    public partial class action
    {
        public int ID_ACTION { get; set; }
        public int ID_REUNION { get; set; }
        public int ID_USER { get; set; }
        public string DESIGNATION { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
    
        public virtual utilisateur utilisateur { get; set; }
        public virtual reunions reunions { get; set; }
    }
}
