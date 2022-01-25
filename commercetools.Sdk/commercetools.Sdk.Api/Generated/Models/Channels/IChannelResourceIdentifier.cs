using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelResourceIdentifier))]
    public partial interface IChannelResourceIdentifier : IResourceIdentifier
    {
        new string Id { get; set; }

        new string Key { get; set; }
    }
}
