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
    
    public partial class employee_salary_Details
    {
        public int id { get; set; }
        public Nullable<int> employee_id { get; set; }
        public Nullable<decimal> salary_paid { get; set; }
        public Nullable<System.DateTime> paid_date { get; set; }
    
        public virtual employee1 employee { get; set; }
    }
}
