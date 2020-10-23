using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public  partial class ShoppingListChangeNameAction : IShoppingListChangeNameAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Name { get; set;}
        public ShoppingListChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
