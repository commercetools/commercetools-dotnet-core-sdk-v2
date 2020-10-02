using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListUpdate 
    {
        public long Version { get; set;}
        
        public List<ShoppingListUpdateAction> Actions { get; set;}
    }
}
