//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G6_SISAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instructor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instructor()
        {
            this.TeachingAssignments1 = new HashSet<TeachingAssignment>();
        }
    
        public string InstructorID { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }
        public int InstructorPhone { get; set; }
        public System.DateTime InstructorHireDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeachingAssignment> TeachingAssignments1 { get; set; }
    }
}
