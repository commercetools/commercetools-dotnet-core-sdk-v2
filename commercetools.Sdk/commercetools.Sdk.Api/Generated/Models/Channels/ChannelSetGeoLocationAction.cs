using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Channels
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
