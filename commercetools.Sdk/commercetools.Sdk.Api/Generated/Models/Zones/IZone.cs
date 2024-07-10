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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.Zone))]
    public partial interface IZone : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        IList<ILocation> Locations { get; set; }
        IEnumerable<ILocation> LocationsEnumerable { set => Locations = value.ToList(); }


    }
}
