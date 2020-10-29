using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartAddItemShippingAddressAction))]
    public interface ICartAddItemShippingAddressAction : ICartUpdateAction
    {
        IAddress Address { get; set;}
    }
}
