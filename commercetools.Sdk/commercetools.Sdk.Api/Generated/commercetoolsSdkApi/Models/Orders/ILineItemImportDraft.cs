using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.LineItemImportDraft))]
    public partial interface ILineItemImportDraft
    {
        ILocalizedString Name { get; set; }

        string Key { get; set; }

        IProductVariantImportDraft Variant { get; set; }

        string ProductId { get; set; }

        long Quantity { get; set; }

        IPriceDraft Price { get; set; }

        ITaxRate TaxRate { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IInventoryMode InventoryMode { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        IList<IItemState> State { get; set; }

        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }

        ICustomFieldsDraft Custom { get; set; }

    }
}
