using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public class MyShoppingListUpdate 
    {
        public long Version { get; set;}
        
        public List<MyShoppingListUpdateAction> Actions { get; set;}
    }
}
