using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetVatIdAction))]
    public partial interface ICustomerSetVatIdAction : ICustomerUpdateAction
    {
        string VatId { get; set; }

    }
}
