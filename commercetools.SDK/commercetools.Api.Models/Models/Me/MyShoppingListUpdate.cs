using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListUpdate 
    {
        public long Version { get; set;}
        
        public List<MyShoppingListUpdateAction> Actions { get; set;}
    }
}
