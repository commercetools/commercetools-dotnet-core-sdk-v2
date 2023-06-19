using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CustomLineItemImportDraft))]
    public partial interface ICustomLineItemImportDraft
    {
        ILocalizedString Name { get; set; }

        long Quantity { get; set; }

        IMoney Money { get; set; }

        string Slug { get; set; }

        IList<IItemState> State { get; set; }
        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


        ITaxRate TaxRate { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        ICustomLineItemPriceMode PriceMode { get; set; }

    }
}
