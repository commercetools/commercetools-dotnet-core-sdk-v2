using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartRemoveDiscountCodeAction))]
    public interface ICartRemoveDiscountCodeAction : ICartUpdateAction
    {
        IDiscountCodeReference DiscountCode { get; set;}
    }
}
