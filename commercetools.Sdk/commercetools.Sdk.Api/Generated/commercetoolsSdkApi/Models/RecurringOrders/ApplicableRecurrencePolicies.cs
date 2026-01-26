using commercetools.Sdk.Api.Models.RecurrencePolicies;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class ApplicableRecurrencePolicies : IApplicableRecurrencePolicies
    {
        public string Type { get; set; }

        public IList<IRecurrencePolicyReference> RecurrencePolicies { get; set; }

        public IEnumerable<IRecurrencePolicyReference> RecurrencePoliciesEnumerable { set => RecurrencePolicies = value.ToList(); }
        public ApplicableRecurrencePolicies()
        {
            this.Type = "ApplicableRecurrencePolicies";
        }
    }
}
