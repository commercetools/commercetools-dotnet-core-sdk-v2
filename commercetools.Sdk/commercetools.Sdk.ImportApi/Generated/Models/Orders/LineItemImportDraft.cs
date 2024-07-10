using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using commercetools.Sdk.ImportApi.Models.Orders;
using commercetools.Sdk.ImportApi.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class LineItemImportDraft : ILineItemImportDraft
    {
        public IProductKeyReference Product { get; set; }

        public ILocalizedString Name { get; set; }

        public ILineItemProductVariantImportDraft Variant { get; set; }

        public ILineItemPrice Price { get; set; }

        public long Quantity { get; set; }

        public IList<IItemState> State { get; set; }
        public IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


        public IChannelKeyReference SupplyChannel { get; set; }

        public IChannelKeyReference DistributionChannel { get; set; }

        public ITaxRate TaxRate { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }

        public ICustom Custom { get; set; }
    }
}
