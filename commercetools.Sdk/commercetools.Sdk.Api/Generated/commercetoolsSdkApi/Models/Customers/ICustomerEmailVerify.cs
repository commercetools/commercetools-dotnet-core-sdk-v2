using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerEmailVerify))]
    public partial interface ICustomerEmailVerify
    {
        long? Version { get; set; }

        string TokenValue { get; set; }

    }
}
