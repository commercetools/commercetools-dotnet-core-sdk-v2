using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.CustomLineItemImportDraft))]
    public partial interface ICustomLineItemImportDraft
    {
        ILocalizedString Name { get; set; }

        string Key { get; set; }

        string Slug { get; set; }

        long Quantity { get; set; }

        IMoney Money { get; set; }

        ITaxRate TaxRate { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        ICustomLineItemPriceMode PriceMode { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        IList<IItemState> State { get; set; }
        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

    }
}
