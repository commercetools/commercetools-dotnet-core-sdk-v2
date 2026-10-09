using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPayment))]
    public partial interface IRecurringPayment
    {
        string Id { get; set; }

        int Version { get; set; }

        string Key { get; set; }

        IRecurringOrderReference RecurringOrder { get; set; }

        IList<IPaymentMethodConfiguration> PaymentMethodConfigurations { get; set; }

        IEnumerable<IPaymentMethodConfiguration> PaymentMethodConfigurationsEnumerable { set => PaymentMethodConfigurations = value.ToList(); }

        DateTime CreatedAt { get; set; }

        DateTime LastModifiedAt { get; set; }

    }
}
