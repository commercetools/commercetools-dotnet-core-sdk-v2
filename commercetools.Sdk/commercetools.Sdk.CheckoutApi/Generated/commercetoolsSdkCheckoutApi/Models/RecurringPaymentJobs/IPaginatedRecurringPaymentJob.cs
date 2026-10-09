using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.PaginatedRecurringPaymentJob))]
    public partial interface IPaginatedRecurringPaymentJob
    {
        int Limit { get; set; }

        int Offset { get; set; }

        int Count { get; set; }

        int? Total { get; set; }

        IList<IRecurringPaymentJob> Results { get; set; }

        IEnumerable<IRecurringPaymentJob> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
