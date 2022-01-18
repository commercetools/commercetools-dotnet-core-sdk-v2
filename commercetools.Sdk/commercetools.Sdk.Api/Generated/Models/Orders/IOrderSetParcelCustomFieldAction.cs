using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetParcelCustomFieldAction))]
    public partial interface IOrderSetParcelCustomFieldAction : IOrderUpdateAction
    {
        string ParcelId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
