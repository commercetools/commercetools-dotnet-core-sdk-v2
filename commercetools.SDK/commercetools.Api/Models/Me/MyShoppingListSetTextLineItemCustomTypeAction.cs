using commercetools.Api.Models.Me;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setTextLineItemCustomType")]
    public partial class MyShoppingListSetTextLineItemCustomTypeAction : MyShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public MyShoppingListSetTextLineItemCustomTypeAction()
        { 
           this.Action = "setTextLineItemCustomType";
        }
    }
}
