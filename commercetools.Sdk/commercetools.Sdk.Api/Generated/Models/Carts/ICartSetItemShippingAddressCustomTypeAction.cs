using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetItemShippingAddressCustomTypeAction))]
    public partial interface ICartSetItemShippingAddressCustomTypeAction : ICartUpdateAction
    {
        string AddressKey { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
