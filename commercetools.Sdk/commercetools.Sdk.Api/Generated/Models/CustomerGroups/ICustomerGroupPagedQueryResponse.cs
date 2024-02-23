using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupPagedQueryResponse))]
    public partial interface ICustomerGroupPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<ICustomerGroup> Results { get; set; }
        IEnumerable<ICustomerGroup> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
