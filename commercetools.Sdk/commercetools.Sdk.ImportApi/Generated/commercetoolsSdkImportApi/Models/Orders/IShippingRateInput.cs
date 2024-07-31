using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Orders.ShippingRateInput))]
    [SubTypeDiscriminator("Classification", typeof(commercetools.Sdk.ImportApi.Models.Orders.ClassificationShippingRateInput))]
    [SubTypeDiscriminator("Score", typeof(commercetools.Sdk.ImportApi.Models.Orders.ScoreShippingRateInput))]
    public partial interface IShippingRateInput
    {
        IShippingRateInputType Type { get; set; }

        static commercetools.Sdk.ImportApi.Models.Orders.ClassificationShippingRateInput Classification(Action<commercetools.Sdk.ImportApi.Models.Orders.ClassificationShippingRateInput> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Orders.ClassificationShippingRateInput();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Orders.ScoreShippingRateInput Score(Action<commercetools.Sdk.ImportApi.Models.Orders.ScoreShippingRateInput> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Orders.ScoreShippingRateInput();
            init?.Invoke(t);
            return t;
        }
    }
}
