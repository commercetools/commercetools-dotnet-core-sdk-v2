using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetDeliveryAddressCustomFieldAction))]
    public partial interface ICartSetDeliveryAddressCustomFieldAction : ICartUpdateAction
    {
        string DeliveryId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
