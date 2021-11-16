using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerEmailVerify))]
    public partial interface ICustomerEmailVerify
    {
        long? Version { get; set; }

        string TokenValue { get; set; }
    }
}
