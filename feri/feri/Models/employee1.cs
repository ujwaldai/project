//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace feri.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee1()
        {
            this.employee_salary_Details = new HashSet<employee_salary_Details>();
        }
    
        public int employee_id { get; set; }
        public string emp_name { get; set; }
        public string emp_address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee_salary_Details> employee_salary_Details { get; set; }
    }
}
