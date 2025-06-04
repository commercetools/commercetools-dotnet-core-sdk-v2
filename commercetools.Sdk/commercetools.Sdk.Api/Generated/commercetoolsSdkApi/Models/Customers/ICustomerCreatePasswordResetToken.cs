using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerCreatePasswordResetToken))]
    public partial interface ICustomerCreatePasswordResetToken
    {
        string Email { get; set; }

        long? TtlMinutes { get; set; }

        bool? InvalidateOlderTokens { get; set; }

    }
}
