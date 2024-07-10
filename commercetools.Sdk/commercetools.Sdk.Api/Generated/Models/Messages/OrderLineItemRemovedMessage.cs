using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderLineItemRemovedMessage : IOrderLineItemRemovedMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public long RemovedQuantity { get; set; }

        public long NewQuantity { get; set; }

        public IList<IItemState> NewState { get; set; }
        public IEnumerable<IItemState> NewStateEnumerable { set => NewState = value.ToList(); }


        public ICentPrecisionMoney NewTotalPrice { get; set; }

        public ITaxedItemPrice NewTaxedPrice { get; set; }

        public IPrice NewPrice { get; set; }

        public IItemShippingDetails NewShippingDetail { get; set; }
        public OrderLineItemRemovedMessage()
        {
            this.Type = "OrderLineItemRemoved";
        }
    }
}
