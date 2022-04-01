using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerEmailVerify))]
    public partial interface ICustomerEmailVerify
    {
        long? Version { get; set; }

        string TokenValue { get; set; }
    }
}
