using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerPagedQueryResponse))]
    public partial interface ICustomerPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<ICustomer> Results { get; set; }
        IEnumerable<ICustomer> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
