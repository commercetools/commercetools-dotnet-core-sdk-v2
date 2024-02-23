using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelChangeNameAction : IChannelChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public ChannelChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
