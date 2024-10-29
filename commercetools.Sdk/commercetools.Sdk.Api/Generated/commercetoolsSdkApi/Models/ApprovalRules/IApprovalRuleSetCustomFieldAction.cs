using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetCustomFieldAction))]
    public partial interface IApprovalRuleSetCustomFieldAction : IApprovalRuleUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
