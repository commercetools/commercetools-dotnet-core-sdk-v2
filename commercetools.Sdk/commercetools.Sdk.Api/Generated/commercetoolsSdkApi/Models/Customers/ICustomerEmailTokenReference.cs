using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerEmailTokenReference))]
    public partial interface ICustomerEmailTokenReference : IReference
    {
        new string Id { get; set; }

    }
}
