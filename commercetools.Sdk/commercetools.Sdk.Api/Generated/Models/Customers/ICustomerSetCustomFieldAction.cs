using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetCustomFieldAction))]
    public partial interface ICustomerSetCustomFieldAction : ICustomerUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
