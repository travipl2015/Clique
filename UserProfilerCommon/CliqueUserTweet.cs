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
    
    public partial class CliqueUserTweet
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int TweetId { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime ModifiedAt { get; set; }
    
        public virtual CliqueRequest CliqueRequest { get; set; }
        public virtual CliqueTweet CliqueTweet { get; set; }
    }
}
