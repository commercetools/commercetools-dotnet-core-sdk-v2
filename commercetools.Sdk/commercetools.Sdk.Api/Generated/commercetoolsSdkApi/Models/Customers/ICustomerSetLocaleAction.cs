using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetLocaleAction))]
    public partial interface ICustomerSetLocaleAction : ICustomerUpdateAction
    {
        string Locale { get; set; }

    }
}
