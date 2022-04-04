using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerCreatePasswordResetToken))]
    public partial interface ICustomerCreatePasswordResetToken
    {
        string Email { get; set; }

        long? TtlMinutes { get; set; }
    }
}
