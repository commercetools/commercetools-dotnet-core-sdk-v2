using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class ShippingInfoImportDraft : IShippingInfoImportDraft
    {
        public string ShippingMethodName { get; set; }

        public ITypedMoney Price { get; set; }

        public IShippingRateDraft ShippingRate { get; set; }

        public ITaxRate TaxRate { get; set; }

        public ITaxCategoryKeyReference TaxCategory { get; set; }

        public IShippingMethodKeyReference ShippingMethod { get; set; }

        public List<IDelivery> Deliveries { get; set; }

        public IDiscountedLineItemPriceDraft DiscountedPrice { get; set; }

        public IShippingMethodState ShippingMethodState { get; set; }
    }
}
