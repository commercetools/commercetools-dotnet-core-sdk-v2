using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.Payments;
using commercetools.Sdk.CheckoutApi.Models.RecurringPayments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.RecurringPaymentJob))]
    public partial interface IRecurringPaymentJob
    {
        string Id { get; set; }

        int Version { get; set; }

        string Key { get; set; }

        IPaymentReference OriginPayment { get; set; }

        IPaymentMethodReference PaymentMethod { get; set; }

        IList<IRecurringPaymentReference> RecurringPayments { get; set; }

        IEnumerable<IRecurringPaymentReference> RecurringPaymentsEnumerable { set => RecurringPayments = value.ToList(); }

        IRecurringPaymentJobStatus Status { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime LastModifiedAt { get; set; }

    }
}
