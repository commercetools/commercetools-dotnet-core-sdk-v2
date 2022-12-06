using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemRemovedMessagePayload))]
    public partial interface IOrderLineItemRemovedMessagePayload : IOrderMessagePayload
    {
        string LineItemId { get; set; }

        long RemovedQuantity { get; set; }

        long NewQuantity { get; set; }

        IList<IItemState> NewState { get; set; }
        IEnumerable<IItemState> NewStateEnumerable { set => NewState = value.ToList(); }


        ICentPrecisionMoney NewTotalPrice { get; set; }

        ITaxedItemPrice NewTaxedPrice { get; set; }

        IPrice NewPrice { get; set; }

        IItemShippingDetails NewShippingDetail { get; set; }

    }
}
