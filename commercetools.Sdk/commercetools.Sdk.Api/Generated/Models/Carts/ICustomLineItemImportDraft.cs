using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CustomLineItemImportDraft))]
    public partial interface ICustomLineItemImportDraft
    {
        ILocalizedString Name { get; set; }

        long Quantity { get; set; }

        IMoney Money { get; set; }

        string Slug { get; set; }

        List<IItemState> State { get; set; }

        ITaxRate TaxRate { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
