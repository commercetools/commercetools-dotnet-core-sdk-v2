using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.MyCustomerResetPassword))]
    public partial interface IMyCustomerResetPassword
    {
        string TokenValue { get; set; }

        string NewPassword { get; set; }
    }
}
