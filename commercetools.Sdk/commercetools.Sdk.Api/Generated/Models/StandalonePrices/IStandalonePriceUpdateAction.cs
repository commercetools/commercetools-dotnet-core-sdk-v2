using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceUpdateAction))]
    [SubTypeDiscriminator("changeValue", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeValueAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetCustomTypeAction))]
    [SubTypeDiscriminator("setDiscountedPrice", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetDiscountedPriceAction))]
    public partial interface IStandalonePriceUpdateAction
    {
        string Action { get; set; }

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
    }
}
