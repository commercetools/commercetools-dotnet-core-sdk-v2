using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelSetAddressCustomTypeAction : IChannelSetAddressCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public ChannelSetAddressCustomTypeAction()
        {
            this.Action = "setAddressCustomType";
        }
    }
}
