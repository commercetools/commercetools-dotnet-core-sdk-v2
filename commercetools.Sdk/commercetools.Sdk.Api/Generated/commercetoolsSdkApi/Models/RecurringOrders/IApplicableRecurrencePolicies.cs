using commercetools.Sdk.Api.Models.RecurrencePolicies;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.ApplicableRecurrencePolicies))]
    public partial interface IApplicableRecurrencePolicies : IRecurringOrderScope
    {
        new string Type { get; set; }

        IList<IRecurrencePolicyReference> RecurrencePolicies { get; set; }

        IEnumerable<IRecurrencePolicyReference> RecurrencePoliciesEnumerable { set => RecurrencePolicies = value.ToList(); }

    }
}
