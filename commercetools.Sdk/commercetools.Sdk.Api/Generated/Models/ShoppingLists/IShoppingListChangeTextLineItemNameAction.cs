using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemNameAction))]
    public partial interface IShoppingListChangeTextLineItemNameAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set;}
        
        ILocalizedString Name { get; set;}
    }
}
