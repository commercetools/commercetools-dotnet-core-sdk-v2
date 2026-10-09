using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.Payments;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.RecurringPaymentJobDraft))]
    public partial interface IRecurringPaymentJobDraft
    {
        string Key { get; set; }

        IPaymentReference OriginPayment { get; set; }

        IPaymentMethodReference PaymentMethod { get; set; }

    }
}
