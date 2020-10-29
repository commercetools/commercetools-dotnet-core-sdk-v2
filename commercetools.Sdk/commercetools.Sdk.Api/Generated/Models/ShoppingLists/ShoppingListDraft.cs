using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListDraft : IShoppingListDraft
    {
        public ICustomFieldsDraft Custom { get; set;}
        
        public ICustomerResourceIdentifier Customer { get; set;}
        
        public long? DeleteDaysAfterLastModification { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public string Key { get; set;}
        
        public List<IShoppingListLineItemDraft> LineItems { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Slug { get; set;}
        
        public List<ITextLineItemDraft> TextLineItems { get; set;}
        
        public string AnonymousId { get; set;}
    }
}
