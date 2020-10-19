using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setCustomField")]
    public partial class MyShoppingListSetCustomFieldAction : MyShoppingListUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public MyShoppingListSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
