using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddCustomLineItemAction))]
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
