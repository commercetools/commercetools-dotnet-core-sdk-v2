using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitPagedQueryResponse))]
    public partial interface IBusinessUnitPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IBusinessUnit> Results { get; set; }

        IEnumerable<IBusinessUnit> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
