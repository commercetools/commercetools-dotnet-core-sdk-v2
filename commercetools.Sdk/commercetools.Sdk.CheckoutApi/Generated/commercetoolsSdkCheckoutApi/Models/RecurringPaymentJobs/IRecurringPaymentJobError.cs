using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.RecurringPaymentJobError))]
    public partial interface IRecurringPaymentJobError
    {
        string Code { get; set; }

        string Message { get; set; }

    }
}
