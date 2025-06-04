using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerCreateEmailToken))]
    public partial interface ICustomerCreateEmailToken
    {
        string Id { get; set; }

        long? Version { get; set; }

        long TtlMinutes { get; set; }

        bool? InvalidateOlderTokens { get; set; }

    }
}
