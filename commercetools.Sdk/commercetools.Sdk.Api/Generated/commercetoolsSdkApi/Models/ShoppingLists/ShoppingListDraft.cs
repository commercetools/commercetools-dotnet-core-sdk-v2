using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListDraft : IShoppingListDraft
    {
        public ILocalizedString Name { get; set; }

        public ILocalizedString Slug { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }

        public string Key { get; set; }

        public ILocalizedString Description { get; set; }

        public string AnonymousId { get; set; }

        public long? DeleteDaysAfterLastModification { get; set; }

        public IList<IShoppingListLineItemDraft> LineItems { get; set; }

        public IEnumerable<IShoppingListLineItemDraft> LineItemsEnumerable { set => LineItems = value.ToList(); }

        public IList<ITextLineItemDraft> TextLineItems { get; set; }

        public IEnumerable<ITextLineItemDraft> TextLineItemsEnumerable { set => TextLineItems = value.ToList(); }

        public IStoreResourceIdentifier Store { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
