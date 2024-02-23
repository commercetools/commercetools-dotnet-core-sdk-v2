using commercetools.Sdk.Api.Models.ApprovalRules;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalRuleRequestersSetMessagePayload : IApprovalRuleRequestersSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IRuleRequester> Requesters { get; set; }
        public IEnumerable<IRuleRequester> RequestersEnumerable { set => Requesters = value.ToList(); }


        public IList<IRuleRequester> OldRequesters { get; set; }
        public IEnumerable<IRuleRequester> OldRequestersEnumerable { set => OldRequesters = value.ToList(); }

        public ApprovalRuleRequestersSetMessagePayload()
        {
            this.Type = "ApprovalRuleRequestersSet";
        }
    }
}
