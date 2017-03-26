
namespace core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class client
    {
        public client()
        {
            this.projet = new HashSet<projet>();
        }
        [Key]
        public string MATRICULE { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        public string RAISON_SOCIALE { get; set; }
        public string RESPONSABLE1 { get; set; }
        public string RESPONSABLE2 { get; set; }
        public string ADRESSE { get; set; }
        public string TEL1 { get; set; }
        public string TEL2 { get; set; }
        public string EMAIL { get; set; }
    
        public virtual ICollection<projet> projet { get; set; }
    }
}
