using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelSetAddressAction))]
    public partial interface IChannelSetAddressAction : IChannelUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
