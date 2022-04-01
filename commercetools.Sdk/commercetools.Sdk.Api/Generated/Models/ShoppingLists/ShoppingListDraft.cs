using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    public partial class ShoppingListDraft : IShoppingListDraft
    {
        public ICustomFieldsDraft Custom { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }

        public long? DeleteDaysAfterLastModification { get; set; }

        public ILocalizedString Description { get; set; }

        public string Key { get; set; }

        public List<IShoppingListLineItemDraft> LineItems { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Slug { get; set; }

        public List<ITextLineItemDraft> TextLineItems { get; set; }

        public string AnonymousId { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
    }
}
