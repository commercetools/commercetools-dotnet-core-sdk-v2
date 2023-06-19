using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceUpdateAction))]
    [SubTypeDiscriminator("applyStagedChanges", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceApplyStagedChangesAction))]
    [SubTypeDiscriminator("changeActive", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeActiveAction))]
    [SubTypeDiscriminator("changeValue", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeValueAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetCustomTypeAction))]
    [SubTypeDiscriminator("setDiscountedPrice", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetDiscountedPriceAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetKeyAction))]
    [SubTypeDiscriminator("setValidFrom", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidFromAction))]
    [SubTypeDiscriminator("setValidFromAndUntil", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidFromAndUntilAction))]
    [SubTypeDiscriminator("setValidUntil", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidUntilAction))]
    public partial interface IStandalonePriceUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceApplyStagedChangesAction ApplyStagedChanges(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceApplyStagedChangesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceApplyStagedChangesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeActiveAction ChangeActive(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeActiveAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeActiveAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeValueAction ChangeValue(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeValueAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeValueAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetDiscountedPriceAction SetDiscountedPrice(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetDiscountedPriceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetDiscountedPriceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidFromAction SetValidFrom(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidFromAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidFromAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidFromAndUntilAction SetValidFromAndUntil(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidFromAndUntilAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidFromAndUntilAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidUntilAction SetValidUntil(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidUntilAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidUntilAction();
            init?.Invoke(t);
            return t;
        }
    }
}
