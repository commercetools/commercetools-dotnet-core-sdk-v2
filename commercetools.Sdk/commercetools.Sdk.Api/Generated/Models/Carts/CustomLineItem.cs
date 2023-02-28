using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CustomLineItem : ICustomLineItem
    {
        public string Id { get; set; }

        public ILocalizedString Name { get; set; }

        public ITypedMoney Money { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }

        public ICentPrecisionMoney TotalPrice { get; set; }

        public string Slug { get; set; }

        public long Quantity { get; set; }

        public IList<IItemState> State { get; set; }
        public IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


        public ITaxCategoryReference TaxCategory { get; set; }

        public ITaxRate TaxRate { get; set; }

        public IList<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }
        public IEnumerable<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }


        public ICustomFields Custom { get; set; }

        public IItemShippingDetails ShippingDetails { get; set; }

        public ICustomLineItemPriceMode PriceMode { get; set; }
    }
}
