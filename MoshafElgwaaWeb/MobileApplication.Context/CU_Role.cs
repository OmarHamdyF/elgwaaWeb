//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileApplication.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class CU_Role
    {
        public CU_Role()
        {
            this.CU_Employee_Role = new HashSet<CU_Employee_Role>();
            this.CU_Role_Program = new HashSet<CU_Role_Program>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<CU_Employee_Role> CU_Employee_Role { get; set; }
        public virtual ICollection<CU_Role_Program> CU_Role_Program { get; set; }
    }
}
