using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Channels
{
    public partial class ChannelSetCustomTypeAction : IChannelSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public ChannelSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
