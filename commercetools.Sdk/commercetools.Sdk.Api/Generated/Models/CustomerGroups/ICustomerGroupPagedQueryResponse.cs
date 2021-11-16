using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupPagedQueryResponse))]
    public partial interface ICustomerGroupPagedQueryResponse
    {
        long Offset { get; set; }

        long Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        List<ICustomerGroup> Results { get; set; }
    }
}
