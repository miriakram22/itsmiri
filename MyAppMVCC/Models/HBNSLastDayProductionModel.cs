//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyAppMVCC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HBNSLastDayProductionModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HBNSLastDayProductionModel()
        {
            this.ELMLastDayProductionModel = new HashSet<ELMLastDayProductionModel>();
        }
    
        public System.DateTime Date_ { get; set; }
        public float Volume { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELMLastDayProductionModel> ELMLastDayProductionModel { get; set; }
    }
}
