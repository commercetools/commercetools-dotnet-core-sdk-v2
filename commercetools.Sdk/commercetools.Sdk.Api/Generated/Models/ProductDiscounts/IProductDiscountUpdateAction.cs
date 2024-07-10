using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountUpdateAction))]
    [SubTypeDiscriminator("changeIsActive", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeIsActiveAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeNameAction))]
    [SubTypeDiscriminator("changePredicate", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangePredicateAction))]
    [SubTypeDiscriminator("changeSortOrder", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeSortOrderAction))]
    [SubTypeDiscriminator("changeValue", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeValueAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetKeyAction))]
    [SubTypeDiscriminator("setValidFrom", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAction))]
    [SubTypeDiscriminator("setValidFromAndUntil", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAndUntilAction))]
    [SubTypeDiscriminator("setValidUntil", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidUntilAction))]
    public partial interface IProductDiscountUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeIsActiveAction ChangeIsActive(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeIsActiveAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeIsActiveAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangePredicateAction ChangePredicate(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangePredicateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangePredicateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeSortOrderAction ChangeSortOrder(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeSortOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeSortOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeValueAction ChangeValue(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeValueAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeValueAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAction SetValidFrom(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAndUntilAction SetValidFromAndUntil(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAndUntilAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAndUntilAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidUntilAction SetValidUntil(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidUntilAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidUntilAction();
            init?.Invoke(t);
            return t;
        }
    }
}
