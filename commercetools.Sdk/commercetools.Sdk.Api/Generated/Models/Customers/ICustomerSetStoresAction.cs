using commercetools.Api.Models.Stores;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetStoresAction))]
    public partial interface ICustomerSetStoresAction : ICustomerUpdateAction
    {
        List<IStoreResourceIdentifier> Stores { get; set; }
    }
}
