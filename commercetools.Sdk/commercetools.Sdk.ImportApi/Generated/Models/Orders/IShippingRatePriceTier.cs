using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Orders.ShippingRatePriceTier))]
    [SubTypeDiscriminator("CartClassification", typeof(commercetools.Sdk.ImportApi.Models.Orders.CartClassificationTier))]
    public partial interface IShippingRatePriceTier
    {
        IShippingRateTierType Type { get; set; }

        static commercetools.Sdk.ImportApi.Models.Orders.CartClassificationTier CartClassification(Action<commercetools.Sdk.ImportApi.Models.Orders.CartClassificationTier> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Orders.CartClassificationTier();
            init?.Invoke(t);
            return t;
        }
    }
}
