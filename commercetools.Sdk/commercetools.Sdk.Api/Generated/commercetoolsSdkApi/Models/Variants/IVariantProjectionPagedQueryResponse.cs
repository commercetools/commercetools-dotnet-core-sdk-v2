using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantProjectionPagedQueryResponse))]
    public partial interface IVariantProjectionPagedQueryResponse
    {
        long Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long Offset { get; set; }

        IList<IVariantProjection> Results { get; set; }

        IEnumerable<IVariantProjection> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
