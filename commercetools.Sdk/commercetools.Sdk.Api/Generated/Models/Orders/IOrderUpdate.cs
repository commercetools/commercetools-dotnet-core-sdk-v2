using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderUpdate))]
    public partial interface IOrderUpdate
    {
        long Version { get; set; }

        List<IOrderUpdateAction> Actions { get; set; }
    }
}
