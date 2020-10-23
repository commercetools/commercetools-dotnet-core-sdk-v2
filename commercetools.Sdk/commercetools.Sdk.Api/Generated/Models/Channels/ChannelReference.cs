using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    public  partial class ChannelReference : IChannelReference
    {
        public string TypeId { get; set;}
        
        [JsonIgnore]
        public ReferenceTypeId TypeIdAsEnum => this.TypeId.GetEnum<ReferenceTypeId>();
        
        public string Id { get; set;}
        
        public IChannel Obj { get; set;}
        public ChannelReference()
        { 
           this.TypeId = "channel";
        }
    }
}
