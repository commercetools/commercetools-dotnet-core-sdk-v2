using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListDraft : IMyShoppingListDraft
    {
        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<IShoppingListLineItemDraft> LineItems { get; set; }

        public IEnumerable<IShoppingListLineItemDraft> LineItemsEnumerable { set => LineItems = value.ToList(); }

        public IList<ITextLineItemDraft> TextLineItems { get; set; }

        public IEnumerable<ITextLineItemDraft> TextLineItemsEnumerable { set => TextLineItems = value.ToList(); }

        public ICustomFieldsDraft Custom { get; set; }

        public long? DeleteDaysAfterLastModification { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
    }
}
