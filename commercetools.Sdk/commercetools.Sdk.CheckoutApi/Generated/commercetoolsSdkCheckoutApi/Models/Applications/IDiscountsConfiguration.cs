using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.DiscountsConfiguration))]
    public partial interface IDiscountsConfiguration
    {
        bool AllowDiscounts { get; set; }

    }
}
