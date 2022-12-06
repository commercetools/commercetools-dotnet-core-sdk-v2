using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListDraft))]
    public partial interface IShoppingListDraft
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        ICustomerResourceIdentifier Customer { get; set; }

        string Key { get; set; }

        ILocalizedString Description { get; set; }

        string AnonymousId { get; set; }

        long? DeleteDaysAfterLastModification { get; set; }

        List<IShoppingListLineItemDraft> LineItems { get; set; }

        List<ITextLineItemDraft> TextLineItems { get; set; }

        IStoreResourceIdentifier Store { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
