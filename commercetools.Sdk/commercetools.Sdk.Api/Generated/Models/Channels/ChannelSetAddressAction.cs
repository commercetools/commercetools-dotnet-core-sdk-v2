using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Channels
{
    public partial class ChannelSetAddressAction : IChannelSetAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public ChannelSetAddressAction()
        {
            this.Action = "setAddress";
        }
    }
}
