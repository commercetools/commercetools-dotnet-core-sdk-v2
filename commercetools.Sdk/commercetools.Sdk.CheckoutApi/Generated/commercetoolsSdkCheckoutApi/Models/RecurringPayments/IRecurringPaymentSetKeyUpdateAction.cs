using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetKeyUpdateAction))]
    public partial interface IRecurringPaymentSetKeyUpdateAction : IRecurringPaymentUpdateAction
    {
        string Key { get; set; }

    }
}
