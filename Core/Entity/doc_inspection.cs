
namespace core
{
    using System;
    using System.Collections.Generic;
    
    public partial class doc_inspection
    {
        public int ID_DOC { get; set; }
        public int ID_TACHE { get; set; }
        public string NUM_DOC { get; set; }
        public Nullable<System.DateTime> DATE_EDITION_DOC { get; set; }
        public string URL_DOC { get; set; }
        public string ETAT_DOC { get; set; }
        public string TYPE_DOC { get; set; }
    
        public virtual taches taches { get; set; }
    }
}
