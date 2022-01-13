using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelChangeDescriptionAction))]
    public partial interface IChannelChangeDescriptionAction : IChannelUpdateAction
    {
        ILocalizedString Description { get; set; }
    }
}
