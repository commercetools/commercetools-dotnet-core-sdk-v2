using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRulePagedQueryResponse : IApprovalRulePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IApprovalRule> Results { get; set; }
        public IEnumerable<IApprovalRule> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
