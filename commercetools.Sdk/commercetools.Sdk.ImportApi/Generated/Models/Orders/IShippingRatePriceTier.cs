using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("CartClassification", typeof(commercetools.ImportApi.Models.Orders.CartClassificationTier))]
    public partial interface IShippingRatePriceTier 
    {
        IShippingRateTierType Type { get; set;}
    }
}
