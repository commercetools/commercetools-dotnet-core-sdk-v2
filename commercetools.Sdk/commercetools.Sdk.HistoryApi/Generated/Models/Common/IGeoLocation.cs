using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.GeoLocation))]
    public partial interface IGeoLocation
    {
        string Type { get; set; }

        IList<int> Coordinates { get; set; }
        IEnumerable<int> CoordinatesEnumerable { set => Coordinates = value.ToList(); }


    }
}
