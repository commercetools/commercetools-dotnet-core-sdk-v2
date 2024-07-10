using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemRemovedMessagePayload))]
    public partial interface IOrderLineItemRemovedMessagePayload : IOrderMessagePayload
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

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
