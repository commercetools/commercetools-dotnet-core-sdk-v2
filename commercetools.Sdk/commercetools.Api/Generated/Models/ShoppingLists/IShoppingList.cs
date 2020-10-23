using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Customers;
using commercetools.Api.Generated.Models.ShoppingLists;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShoppingLists
{
    public interface IShoppingList : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        ICustomFields Custom { get; set;}
        
        ICustomerReference Customer { get; set;}
        
        long DeleteDaysAfterLastModification { get; set;}
        
        ILocalizedString Description { get; set;}
        
        string Key { get; set;}
        
        List<IShoppingListLineItem> LineItems { get; set;}
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Slug { get; set;}
        
        List<ITextLineItem> TextLineItems { get; set;}
        
        string AnonymousId { get; set;}
    }
}
