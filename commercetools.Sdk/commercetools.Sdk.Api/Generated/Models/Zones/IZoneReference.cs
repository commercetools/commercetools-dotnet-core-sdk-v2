using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneReference))]
    public partial interface IZoneReference : IReference
    {
        IZone Obj { get; set; }

        new string Id { get; set; }

    }
}
