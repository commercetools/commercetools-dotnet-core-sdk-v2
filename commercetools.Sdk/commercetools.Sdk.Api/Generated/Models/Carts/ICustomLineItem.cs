using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CustomLineItem))]
    public partial interface ICustomLineItem
    {
        string Id { get; set; }

        ILocalizedString Name { get; set; }

        ITypedMoney Money { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

        ICentPrecisionMoney TotalPrice { get; set; }

        string Slug { get; set; }

        long Quantity { get; set; }

        IList<IItemState> State { get; set; }
        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


        ITaxCategoryReference TaxCategory { get; set; }

        ITaxRate TaxRate { get; set; }

        IList<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }
        IEnumerable<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }


        ICustomFields Custom { get; set; }

        IItemShippingDetails ShippingDetails { get; set; }

        ICustomLineItemPriceMode PriceMode { get; set; }

    }
}
