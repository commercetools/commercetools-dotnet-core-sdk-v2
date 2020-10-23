using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    public  partial class ChannelChangeKeyAction : IChannelChangeKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public ChannelChangeKeyAction()
        { 
           this.Action = "changeKey";
        }
    }
}
