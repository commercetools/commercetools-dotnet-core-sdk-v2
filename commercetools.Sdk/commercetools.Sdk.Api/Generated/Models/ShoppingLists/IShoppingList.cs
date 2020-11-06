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
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingList))]
    public partial interface IShoppingList : IBaseResource
    {
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        ICustomFields Custom { get; set;}
        
        ICustomerReference Customer { get; set;}
        
        long? DeleteDaysAfterLastModification { get; set;}
        
        ILocalizedString Description { get; set;}
        
        string Key { get; set;}
        
        List<IShoppingListLineItem> LineItems { get; set;}
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Slug { get; set;}
        
        List<ITextLineItem> TextLineItems { get; set;}
        
        string AnonymousId { get; set;}
    }
}
