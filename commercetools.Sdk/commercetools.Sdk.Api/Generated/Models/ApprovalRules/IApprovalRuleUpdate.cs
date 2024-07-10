using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleUpdate))]
    public partial interface IApprovalRuleUpdate
    {
        long Version { get; set; }

        IList<IApprovalRuleUpdateAction> Actions { get; set; }
        IEnumerable<IApprovalRuleUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
