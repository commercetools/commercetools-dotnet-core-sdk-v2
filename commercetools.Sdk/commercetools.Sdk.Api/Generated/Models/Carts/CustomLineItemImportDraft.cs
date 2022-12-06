using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CustomLineItemImportDraft : ICustomLineItemImportDraft
    {
        public ILocalizedString Name { get; set; }

        public long Quantity { get; set; }

        public IMoney Money { get; set; }

        public string Slug { get; set; }

        public IList<IItemState> State { get; set; }
        public IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


        public ITaxRate TaxRate { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }

        public ICustomLineItemPriceMode PriceMode { get; set; }
    }
}
