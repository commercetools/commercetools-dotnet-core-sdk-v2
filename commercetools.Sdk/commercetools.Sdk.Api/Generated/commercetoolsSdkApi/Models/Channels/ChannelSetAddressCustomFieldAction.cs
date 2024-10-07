using System;

namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelSetAddressCustomFieldAction : IChannelSetAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public ChannelSetAddressCustomFieldAction()
        {
            this.Action = "setAddressCustomField";
        }
    }
}
