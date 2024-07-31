using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Carts.ShippingRateInputDraft))]
    [SubTypeDiscriminator("Classification", typeof(commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInputDraft))]
    [SubTypeDiscriminator("Score", typeof(commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInputDraft))]
    public partial interface IShippingRateInputDraft
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInputDraft Classification(Action<commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInputDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInputDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInputDraft Score(Action<commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInputDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInputDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
