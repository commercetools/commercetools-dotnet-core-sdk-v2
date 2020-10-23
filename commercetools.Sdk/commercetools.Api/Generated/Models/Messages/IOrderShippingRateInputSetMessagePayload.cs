using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IOrderShippingRateInputSetMessagePayload : IMessagePayload
    {
        IShippingRateInput ShippingRateInput { get; set;}
        
        IShippingRateInput OldShippingRateInput { get; set;}
    }
}
