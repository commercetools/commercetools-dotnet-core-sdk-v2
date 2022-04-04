using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetDeliveryAddressCustomFieldAction))]
    public partial interface ICartSetDeliveryAddressCustomFieldAction : ICartUpdateAction
    {
        string DeliveryId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
