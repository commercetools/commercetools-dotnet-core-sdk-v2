using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
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
