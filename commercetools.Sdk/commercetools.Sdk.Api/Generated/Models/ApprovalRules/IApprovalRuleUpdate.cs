using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
