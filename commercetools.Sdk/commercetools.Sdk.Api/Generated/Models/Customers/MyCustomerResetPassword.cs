namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class MyCustomerResetPassword : IMyCustomerResetPassword
    {
        public string TokenValue { get; set; }

        public string NewPassword { get; set; }
    }
}
