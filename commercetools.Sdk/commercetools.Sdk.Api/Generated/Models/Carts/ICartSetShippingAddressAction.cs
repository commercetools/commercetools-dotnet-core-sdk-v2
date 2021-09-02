using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetShippingAddressAction))]
    public partial interface ICartSetShippingAddressAction : ICartUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
