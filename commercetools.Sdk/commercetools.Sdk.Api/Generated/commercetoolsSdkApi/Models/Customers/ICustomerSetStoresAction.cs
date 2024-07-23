using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetStoresAction))]
    public partial interface ICustomerSetStoresAction : ICustomerUpdateAction
    {
        IList<IStoreResourceIdentifier> Stores { get; set; }
        IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }


    }
}
