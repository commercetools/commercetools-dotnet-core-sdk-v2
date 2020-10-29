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
    public partial class MyShoppingList : IMyShoppingList
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public ICustomFields Custom { get; set;}
        
        public ICustomerReference Customer { get; set;}
        
        public long? DeleteDaysAfterLastModification { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public string Key { get; set;}
        
        public List<IShoppingListLineItem> LineItems { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Slug { get; set;}
        
        public List<ITextLineItem> TextLineItems { get; set;}
        
        public string AnonymousId { get; set;}
    }
}
