
namespace core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class roles
    {
        public roles()
        {
            this.utilisateur = new HashSet<utilisateur>();
        }
        [Key]
        public int ID_ROLE { get; set; }
        public string NOM_ROLE { get; set; }
    
        public virtual ICollection<utilisateur> utilisateur { get; set; }
    }
}
