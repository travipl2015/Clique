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
    
    public partial class TwitterKeyword
    {
        public TwitterKeyword()
        {
            this.TwitterMessages = new HashSet<TwitterMessage>();
        }
    
        public int Id { get; set; }
        public string Keyword { get; set; }
        public string GeoLocation { get; set; }
        public Nullable<decimal> GeoLatitude { get; set; }
        public Nullable<decimal> GeoLogitude { get; set; }
        public Nullable<int> GeoRadious { get; set; }
        public bool TrackMessage { get; set; }
        public Nullable<System.DateTime> AddedAt { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
    
        public virtual ICollection<TwitterMessage> TwitterMessages { get; set; }
    }
}
