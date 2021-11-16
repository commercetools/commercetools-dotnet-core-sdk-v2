using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelSetGeoLocationAction))]
    public partial interface IChannelSetGeoLocationAction : IChannelUpdateAction
    {
        IGeoJson GeoLocation { get; set;}
    }
}
