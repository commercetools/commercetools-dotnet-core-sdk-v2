using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerReference))]
    public partial interface ICustomerReference : IReference
    {
        ICustomer Obj { get; set; }

        new string Id { get; set; }

    }
}
