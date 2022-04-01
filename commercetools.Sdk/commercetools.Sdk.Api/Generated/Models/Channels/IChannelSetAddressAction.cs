using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetAddressAction))]
    public partial interface IChannelSetAddressAction : IChannelUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
