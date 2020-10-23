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
    public interface IShoppingListDraft 
    {
        ICustomFieldsDraft Custom { get; set;}
        
        ICustomerResourceIdentifier Customer { get; set;}
        
        long DeleteDaysAfterLastModification { get; set;}
        
        ILocalizedString Description { get; set;}
        
        string Key { get; set;}
        
        List<IShoppingListLineItemDraft> LineItems { get; set;}
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Slug { get; set;}
        
        List<ITextLineItemDraft> TextLineItems { get; set;}
        
        string AnonymousId { get; set;}
    }
}
