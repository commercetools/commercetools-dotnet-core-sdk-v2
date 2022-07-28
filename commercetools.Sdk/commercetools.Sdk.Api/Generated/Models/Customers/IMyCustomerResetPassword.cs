using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.MyCustomerResetPassword))]
    public partial interface IMyCustomerResetPassword
    {
        string TokenValue { get; set; }

        string NewPassword { get; set; }

    }
}
