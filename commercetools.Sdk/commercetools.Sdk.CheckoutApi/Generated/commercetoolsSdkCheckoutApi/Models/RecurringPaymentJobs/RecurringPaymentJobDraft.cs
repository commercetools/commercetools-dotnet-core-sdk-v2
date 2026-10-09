using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.Payments;


namespace commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs
{

    public partial class RecurringPaymentJobDraft : IRecurringPaymentJobDraft
    {
        public string Key { get; set; }

        public IPaymentReference OriginPayment { get; set; }

        public IPaymentMethodReference PaymentMethod { get; set; }
    }
}
