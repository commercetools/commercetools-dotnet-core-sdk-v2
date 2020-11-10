using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class MissingRoleOnChannelError : IMissingRoleOnChannelError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public IChannelResourceIdentifier Channel { get; set;}
        
        public string MissingRole { get; set;}
        
        [JsonIgnore]
        public ChannelRoleEnum MissingRoleAsEnum => this.MissingRole.GetEnum<ChannelRoleEnum>();
        public MissingRoleOnChannelError()
        { 
           this.Code = "MissingRoleOnChannel";
        }
    }
}
