using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Carts.ShippingRateInput))]
    [SubTypeDiscriminator("Classification", typeof(commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInput))]
    [SubTypeDiscriminator("Score", typeof(commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInput))]
    public partial interface IShippingRateInput
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInput Classification(Action<commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInput> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInput();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInput Score(Action<commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInput> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInput();
            init?.Invoke(t);
            return t;
        }
    }
}
