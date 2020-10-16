using commercetools.Api.Models.Me;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setCustomType")]
    public partial class MyShoppingListSetCustomTypeAction : MyShoppingListUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public MyShoppingListSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
