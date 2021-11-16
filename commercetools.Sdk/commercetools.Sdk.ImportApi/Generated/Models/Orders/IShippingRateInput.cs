using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.ImportApi.Models.Orders.ShippingRateInput))]
    [SubTypeDiscriminator("Classification", typeof(commercetools.ImportApi.Models.Orders.ClassificationShippingRateInput))]
    [SubTypeDiscriminator("Score", typeof(commercetools.ImportApi.Models.Orders.ScoreShippingRateInput))]
    public partial interface IShippingRateInput 
    {
        IShippingRateInputType Type { get; set;}
    }
}
