using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.ZoneResourceIdentifier))]
    public partial interface IZoneResourceIdentifier : IResourceIdentifier
    {
    }
}
