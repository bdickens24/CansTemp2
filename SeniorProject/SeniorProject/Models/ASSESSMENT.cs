//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeniorProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASSESSMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ASSESSMENT()
        {
            this.ITEM_SCORE = new HashSet<ITEM_SCORE>();
        }
    
        public int AssessmentID { get; set; }
        public int PatientID { get; set; }
        public string UserID { get; set; }
        public System.DateTime AssessmentDate { get; set; }
        public int Number { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual PATIENT PATIENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_SCORE> ITEM_SCORE { get; set; }
    }
}
