using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodePagedQueryResponse))]
    public partial interface IDiscountCodePagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IDiscountCode> Results { get; set; }
        IEnumerable<IDiscountCode> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
