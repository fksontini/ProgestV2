
namespace core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class service
    {
        public service()
        {
            this.projet = new HashSet<projet>();
        }
        [Key]
        public int ID_SERVICE { get; set; }
        public string NOM_SERVICE { get; set; }
        public string CHEF_SERVICE { get; set; }
    
        public virtual ICollection<projet> projet { get; set; }
    }
}
