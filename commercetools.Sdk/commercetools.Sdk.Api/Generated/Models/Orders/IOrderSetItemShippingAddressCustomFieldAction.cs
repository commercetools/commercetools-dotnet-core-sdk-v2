using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetItemShippingAddressCustomFieldAction))]
    public partial interface IOrderSetItemShippingAddressCustomFieldAction : IOrderUpdateAction
    {
        string AddressKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
