using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.GeoJsonPoint))]
    public partial interface IGeoJsonPoint : IGeoJson
    {
        IList<decimal> Coordinates { get; set; }

        IEnumerable<decimal> CoordinatesEnumerable { set => Coordinates = value.ToList(); }

    }
}
