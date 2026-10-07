using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetRecurringPaymentConfigurationAction))]
    public partial interface ICartSetRecurringPaymentConfigurationAction : ICartUpdateAction
    {
        IRecurringPaymentConfigurationDraft RecurringPaymentConfiguration { get; set; }

    }
}
