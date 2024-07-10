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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneUpdate))]
    public partial interface IZoneUpdate
    {
        long Version { get; set; }

        IList<IZoneUpdateAction> Actions { get; set; }
        IEnumerable<IZoneUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
