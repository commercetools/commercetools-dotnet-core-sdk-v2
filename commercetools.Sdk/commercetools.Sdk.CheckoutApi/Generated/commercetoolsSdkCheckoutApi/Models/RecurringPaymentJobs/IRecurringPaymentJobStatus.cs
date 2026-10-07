using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.RecurringPaymentJobStatus))]
    public partial interface IRecurringPaymentJobStatus
    {
        IRecurringPaymentJobState State { get; set; }

        int? Attempts { get; set; }

        IList<IRecurringPaymentJobError> Errors { get; set; }

        IEnumerable<IRecurringPaymentJobError> ErrorsEnumerable { set => Errors = value.ToList(); }

    }
}
