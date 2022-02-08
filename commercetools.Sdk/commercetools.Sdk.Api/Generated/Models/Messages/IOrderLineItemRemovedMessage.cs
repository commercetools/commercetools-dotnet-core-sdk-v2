using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderLineItemRemovedMessage))]
    public partial interface IOrderLineItemRemovedMessage : IOrderMessage
    {
        string LineItemId { get; set; }

        long RemovedQuantity { get; set; }

        long NewQuantity { get; set; }

        List<IItemState> NewState { get; set; }

        ITypedMoney NewTotalPrice { get; set; }

        ITaxedItemPrice NewTaxedPrice { get; set; }

        IPrice NewPrice { get; set; }

        IItemShippingDetails NewShippingDetail { get; set; }
    }
}
