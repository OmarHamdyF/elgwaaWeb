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
    
    public partial class ArticleItemExplanation
    {
        public int ID { get; set; }
        public int ArticleID { get; set; }
        public int ExplanationNumber { get; set; }
        public string ItemExplanation { get; set; }
    
        public virtual Article Article { get; set; }
    }
}