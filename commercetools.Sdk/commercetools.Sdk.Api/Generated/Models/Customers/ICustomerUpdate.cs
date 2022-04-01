using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerUpdate))]
    public partial interface ICustomerUpdate
    {
        long Version { get; set; }

        List<ICustomerUpdateAction> Actions { get; set; }
    }
}
