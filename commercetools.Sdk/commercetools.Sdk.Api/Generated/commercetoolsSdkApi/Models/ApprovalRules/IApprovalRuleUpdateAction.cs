using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleUpdateAction))]
    [SubTypeDiscriminator("setApprovers", typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetApproversAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetCustomTypeAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetKeyAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetNameAction))]
    [SubTypeDiscriminator("setPredicate", typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetPredicateAction))]
    [SubTypeDiscriminator("setRequesters", typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetRequestersAction))]
    [SubTypeDiscriminator("setStatus", typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetStatusAction))]
    public partial interface IApprovalRuleUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetApproversAction SetApprovers(Action<commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetApproversAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetApproversAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetNameAction SetName(Action<commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetPredicateAction SetPredicate(Action<commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetPredicateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetPredicateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetRequestersAction SetRequesters(Action<commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetRequestersAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetRequestersAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetStatusAction SetStatus(Action<commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetStatusAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetStatusAction();
            init?.Invoke(t);
            return t;
        }
    }
}
