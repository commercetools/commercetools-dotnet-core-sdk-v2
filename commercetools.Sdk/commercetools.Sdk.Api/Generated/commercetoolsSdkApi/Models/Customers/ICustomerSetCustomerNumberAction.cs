using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerNumberAction))]
    public partial interface ICustomerSetCustomerNumberAction : ICustomerUpdateAction
    {
        string CustomerNumber { get; set; }

    }
}
