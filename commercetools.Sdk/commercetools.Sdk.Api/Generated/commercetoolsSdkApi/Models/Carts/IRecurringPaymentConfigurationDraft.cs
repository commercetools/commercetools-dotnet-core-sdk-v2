using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.RecurringPaymentConfigurationDraft))]
    public partial interface IRecurringPaymentConfigurationDraft
    {
        IPaymentStrategy PaymentStrategy { get; set; }

        IList<IPaymentAllocationDraft> PaymentAllocations { get; set; }

        IEnumerable<IPaymentAllocationDraft> PaymentAllocationsEnumerable { set => PaymentAllocations = value.ToList(); }

    }
}
