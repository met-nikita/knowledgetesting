//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnowledgeTesting
{
    using System;
    using System.Collections.Generic;
    
    public partial class GQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GQuestion()
        {
            this.GAnswer = new HashSet<GAnswer>();
        }
    
        public int ID { get; set; }
        public string Text { get; set; }
        public int Type { get; set; }
        public int IDts { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAnswer> GAnswer { get; set; }
        public virtual GTest GTest { get; set; }
    }
}