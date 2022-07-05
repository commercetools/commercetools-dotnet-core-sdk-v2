using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelChangeDescriptionAction : IChannelChangeDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public ChannelChangeDescriptionAction()
        {
            this.Action = "changeDescription";
        }
    }
}
