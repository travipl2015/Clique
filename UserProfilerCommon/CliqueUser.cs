//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserProfilerCommon
{
    using System;
    using System.Collections.Generic;
    
    public partial class CliqueUser
    {
        public CliqueUser()
        {
            this.CliqueRequests = new HashSet<CliqueRequest>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string TwitterUserName { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime ModifiedAt { get; set; }
        public Nullable<double> Score { get; set; }
    
        public virtual ICollection<CliqueRequest> CliqueRequests { get; set; }
    }
}
