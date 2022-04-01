namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class MyCustomerChangePassword : IMyCustomerChangePassword
    {
        public long Version { get; set; }

        public string CurrentPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
