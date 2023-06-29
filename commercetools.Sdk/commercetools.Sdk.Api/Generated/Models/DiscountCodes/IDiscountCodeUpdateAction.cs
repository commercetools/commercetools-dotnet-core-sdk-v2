using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeUpdateAction))]
    [SubTypeDiscriminator("changeCartDiscounts", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeCartDiscountsAction))]
    [SubTypeDiscriminator("changeGroups", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeGroupsAction))]
    [SubTypeDiscriminator("changeIsActive", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeIsActiveAction))]
    [SubTypeDiscriminator("setCartPredicate", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCartPredicateAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomTypeAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetDescriptionAction))]
    [SubTypeDiscriminator("setMaxApplications", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsAction))]
    [SubTypeDiscriminator("setMaxApplicationsPerCustomer", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetNameAction))]
    [SubTypeDiscriminator("setValidFrom", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAction))]
    [SubTypeDiscriminator("setValidFromAndUntil", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAndUntilAction))]
    [SubTypeDiscriminator("setValidUntil", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidUntilAction))]
    public partial interface IDiscountCodeUpdateAction
    {
        new string Action { get; set; }

        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeCartDiscountsAction ChangeCartDiscounts(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeCartDiscountsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeCartDiscountsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeGroupsAction ChangeGroups(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeGroupsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeGroupsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeIsActiveAction ChangeIsActive(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeIsActiveAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeIsActiveAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCartPredicateAction SetCartPredicate(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCartPredicateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCartPredicateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsAction SetMaxApplications(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerAction SetMaxApplicationsPerCustomer(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetNameAction SetName(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAction SetValidFrom(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAndUntilAction SetValidFromAndUntil(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAndUntilAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAndUntilAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidUntilAction SetValidUntil(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidUntilAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidUntilAction();
            init?.Invoke(t);
            return t;
        }
    }
}
