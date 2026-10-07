using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.RecurringPaymentConfiguration))]
    public partial interface IRecurringPaymentConfiguration
    {
        IPaymentStrategy PaymentStrategy { get; set; }

        IList<IRecurringPaymentAllocation> PaymentAllocations { get; set; }

        IEnumerable<IRecurringPaymentAllocation> PaymentAllocationsEnumerable { set => PaymentAllocations = value.ToList(); }

    }
}
