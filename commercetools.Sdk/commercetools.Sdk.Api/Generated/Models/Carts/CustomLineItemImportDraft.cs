using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CustomLineItemImportDraft : ICustomLineItemImportDraft
    {
        public ILocalizedString Name { get; set; }

        public long Quantity { get; set; }

        public IMoney Money { get; set; }

        public string Slug { get; set; }

        public List<IItemState> State { get; set; }

        public ITaxRate TaxRate { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }

        public ICustomLineItemPriceMode PriceMode { get; set; }
    }
}
