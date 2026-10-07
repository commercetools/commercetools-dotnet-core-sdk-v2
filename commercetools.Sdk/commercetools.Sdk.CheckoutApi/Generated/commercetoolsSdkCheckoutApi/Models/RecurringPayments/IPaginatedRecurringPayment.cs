using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.PaginatedRecurringPayment))]
    public partial interface IPaginatedRecurringPayment
    {
        int Limit { get; set; }

        int Offset { get; set; }

        int Count { get; set; }

        int? Total { get; set; }

        IList<IRecurringPayment> Results { get; set; }

        IEnumerable<IRecurringPayment> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
