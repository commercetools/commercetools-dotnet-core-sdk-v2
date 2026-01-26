using commercetools.Sdk.Api.Models.RecurrencePolicies;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.ApplicableRecurrencePoliciesDraft))]
    public partial interface IApplicableRecurrencePoliciesDraft : IRecurringOrderScopeDraft
    {
        new string Type { get; set; }

        IList<IRecurrencePolicyResourceIdentifier> RecurrencePolicies { get; set; }

        IEnumerable<IRecurrencePolicyResourceIdentifier> RecurrencePoliciesEnumerable { set => RecurrencePolicies = value.ToList(); }

    }
}
