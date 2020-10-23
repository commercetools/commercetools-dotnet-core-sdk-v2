using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ShoppingLists;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyShoppingListDraft 
    {
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        List<IShoppingListLineItemDraft> LineItems { get; set;}
        
        List<ITextLineItemDraft> TextLineItems { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        long DeleteDaysAfterLastModification { get; set;}
    }
}
