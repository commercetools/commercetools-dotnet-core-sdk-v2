using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Projects.ShippingRateInputType))]
    [SubTypeDiscriminator("CartClassification", typeof(commercetools.Sdk.Api.Models.Projects.CartClassificationType))]
    [SubTypeDiscriminator("CartScore", typeof(commercetools.Sdk.Api.Models.Projects.CartScoreType))]
    [SubTypeDiscriminator("CartValue", typeof(commercetools.Sdk.Api.Models.Projects.CartValueType))]
    public partial interface IShippingRateInputType
    {
        IShippingRateTierType Type { get; set; }

        static commercetools.Sdk.Api.Models.Projects.CartClassificationType CartClassification(Action<commercetools.Sdk.Api.Models.Projects.CartClassificationType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.CartClassificationType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.CartScoreType CartScore(Action<commercetools.Sdk.Api.Models.Projects.CartScoreType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.CartScoreType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.CartValueType CartValue(Action<commercetools.Sdk.Api.Models.Projects.CartValueType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.CartValueType();
            init?.Invoke(t);
            return t;
        }
    }
}
