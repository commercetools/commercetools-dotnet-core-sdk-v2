using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetLineItemCustomFieldAction))]
    public partial interface IOrderSetLineItemCustomFieldAction : IOrderUpdateAction
    {
        string LineItemId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
