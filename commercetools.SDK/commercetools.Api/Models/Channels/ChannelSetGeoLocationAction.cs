using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("setGeoLocation")]
    public partial class ChannelSetGeoLocationAction : ChannelUpdateAction
    {
        public GeoJson GeoLocation { get; set;}
        public ChannelSetGeoLocationAction()
        { 
           this.Action = "setGeoLocation";
        }
    }
}
