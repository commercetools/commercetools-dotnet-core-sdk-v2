using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelChangeDescriptionAction))]
    public partial interface IChannelChangeDescriptionAction : IChannelUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
