using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelReference))]
    public partial interface IChannelReference : IReference
    {
        IChannel Obj { get; set; }
    }
}
