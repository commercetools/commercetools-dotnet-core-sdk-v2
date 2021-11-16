using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelChangeNameAction))]
    public partial interface IChannelChangeNameAction : IChannelUpdateAction
    {
        ILocalizedString Name { get; set;}
    }
}
