using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetRequestersAction))]
    public partial interface IApprovalRuleSetRequestersAction : IApprovalRuleUpdateAction
    {
        IList<IRuleRequesterDraft> Requesters { get; set; }

        IEnumerable<IRuleRequesterDraft> RequestersEnumerable { set => Requesters = value.ToList(); }

    }
}
