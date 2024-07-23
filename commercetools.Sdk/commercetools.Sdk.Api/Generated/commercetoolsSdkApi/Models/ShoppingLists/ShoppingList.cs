using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingList : IShoppingList
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILocalizedString Name { get; set; }

        public string Key { get; set; }

        public ICustomerReference Customer { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<IShoppingListLineItem> LineItems { get; set; }
        public IEnumerable<IShoppingListLineItem> LineItemsEnumerable { set => LineItems = value.ToList(); }


        public IList<ITextLineItem> TextLineItems { get; set; }
        public IEnumerable<ITextLineItem> TextLineItemsEnumerable { set => TextLineItems = value.ToList(); }


        public long? DeleteDaysAfterLastModification { get; set; }

        public string AnonymousId { get; set; }

        public IStoreKeyReference Store { get; set; }

        public ICustomFields Custom { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }
    }
}
