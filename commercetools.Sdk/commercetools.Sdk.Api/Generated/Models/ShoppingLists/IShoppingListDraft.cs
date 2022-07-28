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
        ICustomFieldsDraft Custom { get; set; }

        ICustomerResourceIdentifier Customer { get; set; }

        long? DeleteDaysAfterLastModification { get; set; }

        ILocalizedString Description { get; set; }

        string Key { get; set; }

        List<IShoppingListLineItemDraft> LineItems { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        List<ITextLineItemDraft> TextLineItems { get; set; }

        string AnonymousId { get; set; }

        IStoreResourceIdentifier Store { get; set; }

    }
}
