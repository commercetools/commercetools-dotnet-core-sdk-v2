using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelSetGeoLocationAction : IChannelSetGeoLocationAction
    {
        public string Action { get; set; }

        public IGeoJson GeoLocation { get; set; }
        public ChannelSetGeoLocationAction()
        {
            this.Action = "setGeoLocation";
        }
    }
}
