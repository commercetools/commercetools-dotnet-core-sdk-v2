namespace commercetools.Api.Models.Customers
{
    public partial class CustomerCreatePasswordResetToken : ICustomerCreatePasswordResetToken
    {
        public string Email { get; set; }

        public long? TtlMinutes { get; set; }
    }
}
