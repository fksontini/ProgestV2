
namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class roles
    {
        public roles()
        {
            this.utilisateur = new HashSet<utilisateur>();
        }
    
        public int ID_ROLE { get; set; }
        public string NOM_ROLE { get; set; }
    
        public virtual ICollection<utilisateur> utilisateur { get; set; }
    }
}
