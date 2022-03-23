using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetDeliveryCustomFieldAction))]
    public partial interface IOrderSetDeliveryCustomFieldAction : IOrderUpdateAction
    {
        string DeliveryId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
