using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddCustomLineItemAction : ICartAddCustomLineItemAction
    {
        public string Action { get; set; }

        public IMoney Money { get; set; }

        public ILocalizedString Name { get; set; }

        public string Key { get; set; }

        public long? Quantity { get; set; }

        public string Slug { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public ICustomLineItemPriceMode PriceMode { get; set; }
        public CartAddCustomLineItemAction()
        {
            this.Action = "addCustomLineItem";
        }
    }
}
