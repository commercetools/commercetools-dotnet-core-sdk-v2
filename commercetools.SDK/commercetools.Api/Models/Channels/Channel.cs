using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Channels
{
    public partial class Channel : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public string Key { get; set;}
        
        public List<string> Roles { get; set;}
        
        [JsonIgnore]
        public List<ChannelRoleEnum> RolesAsEnum => this.Roles.GetEnum<ChannelRoleEnum>();
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public Address Address { get; set;}
        
        public ReviewRatingStatistics ReviewRatingStatistics { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public GeoJson GeoLocation { get; set;}
    }
}
