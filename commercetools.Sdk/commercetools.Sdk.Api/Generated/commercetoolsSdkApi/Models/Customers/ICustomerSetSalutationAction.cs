using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetSalutationAction))]
    public partial interface ICustomerSetSalutationAction : ICustomerUpdateAction
    {
        string Salutation { get; set; }

    }
}
