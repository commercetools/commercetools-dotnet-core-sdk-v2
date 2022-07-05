using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListDraft : IMyShoppingListDraft
    {
        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public List<IShoppingListLineItemDraft> LineItems { get; set; }

        public List<ITextLineItemDraft> TextLineItems { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public long? DeleteDaysAfterLastModification { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
    }
}
