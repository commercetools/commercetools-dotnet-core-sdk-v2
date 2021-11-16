using System;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelSetCustomFieldAction : IChannelSetCustomFieldAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public ChannelSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
