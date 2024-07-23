using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelResourceIdentifier))]
    public partial interface IChannelResourceIdentifier : IResourceIdentifier
    {
        new string Id { get; set; }

        new string Key { get; set; }

    }
}
