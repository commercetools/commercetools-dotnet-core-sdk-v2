using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("setGeoLocation")]
    public class ChannelSetGeoLocationAction : ChannelUpdateAction
    {
        public GeoJson GeoLocation { get; set;}
    }
}
