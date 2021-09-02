using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Zones.ZoneUpdateAction))]
    [SubTypeDiscriminator("addLocation", typeof(commercetools.Api.Models.Zones.ZoneAddLocationAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.Zones.ZoneChangeNameAction))]
    [SubTypeDiscriminator("removeLocation", typeof(commercetools.Api.Models.Zones.ZoneRemoveLocationAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.Zones.ZoneSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.Zones.ZoneSetKeyAction))]
    public partial interface IZoneUpdateAction
    {
        string Action { get; set; }
    }
}
