using commercetools.Api.Generated.Models.ShoppingLists;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShoppingLists
{
    public interface IShoppingListSetTextLineItemCustomTypeAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set;}
        
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
