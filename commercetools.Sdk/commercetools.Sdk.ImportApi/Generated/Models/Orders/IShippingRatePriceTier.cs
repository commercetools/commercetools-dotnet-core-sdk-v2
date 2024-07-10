using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
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
