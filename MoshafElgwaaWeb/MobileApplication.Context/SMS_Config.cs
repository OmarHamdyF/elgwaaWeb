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
    
    public partial class SMS_Config
    {
        public SMS_Config()
        {
            this.SMS_ConfigParam = new HashSet<SMS_ConfigParam>();
        }
    
        public int ID { get; set; }
        public string KeyValue { get; set; }
        public string Url { get; set; }
        public Nullable<bool> IsKeyValue { get; set; }
        public Nullable<int> IntervalTimeToSend { get; set; }
        public string MessageParamName { get; set; }
        public string NumberParamName { get; set; }
        public Nullable<int> SuccessResponseNumber { get; set; }
        public Nullable<bool> IsDefault { get; set; }
    
        public virtual ICollection<SMS_ConfigParam> SMS_ConfigParam { get; set; }
    }
}
