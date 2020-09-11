using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingList : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public CustomerReference Customer { get; set;}
        
        public long DeleteDaysAfterLastModification { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public string Key { get; set;}
        
        public List<ShoppingListLineItem> LineItems { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Slug { get; set;}
        
        public List<TextLineItem> TextLineItems { get; set;}
        
        public string AnonymousId { get; set;}
    }
}
