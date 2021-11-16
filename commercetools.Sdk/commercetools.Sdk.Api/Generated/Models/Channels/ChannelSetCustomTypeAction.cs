using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelSetCustomTypeAction : IChannelSetCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public ChannelSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
