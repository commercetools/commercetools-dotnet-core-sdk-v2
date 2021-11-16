namespace commercetools.Api.Models.Customers
{
    public partial class CustomerResetPassword : ICustomerResetPassword
    {
        public string TokenValue { get; set; }

        public string NewPassword { get; set; }

        public long? Version { get; set; }
    }
}
