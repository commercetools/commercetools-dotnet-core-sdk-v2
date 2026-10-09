using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentUpdateActions))]
    public partial interface IRecurringPaymentUpdateActions
    {
        int Version { get; set; }

        IList<IRecurringPaymentUpdateAction> Actions { get; set; }

        IEnumerable<IRecurringPaymentUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
