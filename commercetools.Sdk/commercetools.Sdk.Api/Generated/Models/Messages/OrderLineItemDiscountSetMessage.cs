using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderLineItemDiscountSetMessage : IOrderLineItemDiscountSetMessage
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

        public List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        public IMoney TotalPrice { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }
        public OrderLineItemDiscountSetMessage()
        {
            this.Type = "OrderLineItemDiscountSet";
        }
    }
}
