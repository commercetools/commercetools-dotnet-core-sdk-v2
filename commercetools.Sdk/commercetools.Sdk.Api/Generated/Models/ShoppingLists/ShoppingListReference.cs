using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListReference : IShoppingListReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public IShoppingList Obj { get; set;}
        public ShoppingListReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("shopping-list");
        }
    }
}
