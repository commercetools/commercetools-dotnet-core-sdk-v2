using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerResetPassword))]
    public partial interface ICustomerResetPassword
    {
        string TokenValue { get; set; }

        string NewPassword { get; set; }

        long? Version { get; set; }

    }
}
