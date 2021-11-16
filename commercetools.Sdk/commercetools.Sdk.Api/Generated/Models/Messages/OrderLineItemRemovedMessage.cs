using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;


namespace commercetools.Api.Models.Messages
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

        public long RemovedQuantity { get; set; }

        public long NewQuantity { get; set; }

        public List<IItemState> NewState { get; set; }

        public ITypedMoney NewTotalPrice { get; set; }

        public ITaxedItemPrice NewTaxedPrice { get; set; }

        public IPrice NewPrice { get; set; }

        public IItemShippingDetails NewShippingDetail { get; set; }
        public OrderLineItemRemovedMessage()
        {
            this.Type = "OrderLineItemRemoved";
        }
    }
}
