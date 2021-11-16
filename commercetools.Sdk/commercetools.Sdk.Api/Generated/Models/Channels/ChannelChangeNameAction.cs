using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Channels
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
