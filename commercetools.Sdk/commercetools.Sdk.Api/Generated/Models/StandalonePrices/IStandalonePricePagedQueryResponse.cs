using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePricePagedQueryResponse))]
    public partial interface IStandalonePricePagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IStandalonePrice> Results { get; set; }
        IEnumerable<IStandalonePrice> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
