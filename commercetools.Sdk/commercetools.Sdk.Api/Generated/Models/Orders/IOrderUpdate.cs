using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderUpdate))]
    public partial interface IOrderUpdate
    {
        long Version { get; set; }

        List<IOrderUpdateAction> Actions { get; set; }
    }
}
