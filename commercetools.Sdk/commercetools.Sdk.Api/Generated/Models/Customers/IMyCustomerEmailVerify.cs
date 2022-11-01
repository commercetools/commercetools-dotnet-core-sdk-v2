using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.MyCustomerEmailVerify))]
    public partial interface IMyCustomerEmailVerify
    {
        string TokenValue { get; set; }

    }
}
