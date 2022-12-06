using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemDiscountSetMessage))]
    public partial interface IOrderLineItemDiscountSetMessage : IOrderMessage
    {
        string LineItemId { get; set; }

        IList<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }
        IEnumerable<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }


        IMoney TotalPrice { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

        IList<IMethodTaxedPrice> TaxedPricePortions { get; set; }
        IEnumerable<IMethodTaxedPrice> TaxedPricePortionsEnumerable { set => TaxedPricePortions = value.ToList(); }


    }
}
