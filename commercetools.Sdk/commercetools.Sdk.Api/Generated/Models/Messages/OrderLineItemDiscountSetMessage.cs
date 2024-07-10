using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;


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

        public string LineItemKey { get; set; }

        public IList<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }
        public IEnumerable<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }


        public ICentPrecisionMoney TotalPrice { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }

        public IList<IMethodTaxedPrice> TaxedPricePortions { get; set; }
        public IEnumerable<IMethodTaxedPrice> TaxedPricePortionsEnumerable { set => TaxedPricePortions = value.ToList(); }

        public OrderLineItemDiscountSetMessage()
        {
            this.Type = "OrderLineItemDiscountSet";
        }
    }
}
