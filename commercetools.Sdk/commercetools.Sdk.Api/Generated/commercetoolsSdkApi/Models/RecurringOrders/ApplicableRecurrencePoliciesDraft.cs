using commercetools.Sdk.Api.Models.RecurrencePolicies;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class ApplicableRecurrencePoliciesDraft : IApplicableRecurrencePoliciesDraft
    {
        public string Type { get; set; }

        public IList<IRecurrencePolicyResourceIdentifier> RecurrencePolicies { get; set; }

        public IEnumerable<IRecurrencePolicyResourceIdentifier> RecurrencePoliciesEnumerable { set => RecurrencePolicies = value.ToList(); }
        public ApplicableRecurrencePoliciesDraft()
        {
            this.Type = "ApplicableRecurrencePolicies";
        }
    }
}
