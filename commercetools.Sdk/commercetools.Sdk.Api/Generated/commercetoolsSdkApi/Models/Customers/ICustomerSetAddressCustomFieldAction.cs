using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetAddressCustomFieldAction))]
    public partial interface ICustomerSetAddressCustomFieldAction : ICustomerUpdateAction
    {
        string AddressId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
