using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringPagedQueryResponse))]
    public partial interface IProductTailoringPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IProductTailoring> Results { get; set; }
        IEnumerable<IProductTailoring> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
