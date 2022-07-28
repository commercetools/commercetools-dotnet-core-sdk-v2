using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetStoresAction))]
    public partial interface ICustomerSetStoresAction : ICustomerUpdateAction
    {
        List<IStoreResourceIdentifier> Stores { get; set; }

    }
}
