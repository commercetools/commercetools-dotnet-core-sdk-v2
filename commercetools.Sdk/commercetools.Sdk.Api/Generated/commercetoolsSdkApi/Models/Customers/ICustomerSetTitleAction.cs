using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetTitleAction))]
    public partial interface ICustomerSetTitleAction : ICustomerUpdateAction
    {
        string Title { get; set; }

    }
}
