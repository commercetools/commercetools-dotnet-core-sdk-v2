using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentSetRecurringOrderUpdateAction))]
    public partial interface IRecurringPaymentSetRecurringOrderUpdateAction : IRecurringPaymentUpdateAction
    {
        IRecurringOrderReference RecurringOrder { get; set; }

    }
}
