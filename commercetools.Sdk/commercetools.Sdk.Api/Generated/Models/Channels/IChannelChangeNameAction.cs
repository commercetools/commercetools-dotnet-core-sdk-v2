using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelChangeNameAction))]
    public partial interface IChannelChangeNameAction : IChannelUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
