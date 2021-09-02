using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartAddCustomLineItemAction))]
    public partial interface ICartAddCustomLineItemAction : ICartUpdateAction
    {
        IMoney Money { get; set; }

        ILocalizedString Name { get; set; }

        long Quantity { get; set; }

        string Slug { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }
    }
}
