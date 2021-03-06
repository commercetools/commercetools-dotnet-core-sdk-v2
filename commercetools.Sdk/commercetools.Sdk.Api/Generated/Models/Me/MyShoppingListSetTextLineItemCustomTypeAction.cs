using commercetools.Api.Models.Me;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListSetTextLineItemCustomTypeAction : IMyShoppingListSetTextLineItemCustomTypeAction
    {
        public string Action { get; set;}
        
        public string TextLineItemId { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public MyShoppingListSetTextLineItemCustomTypeAction()
        { 
           this.Action = "setTextLineItemCustomType";
        }
    }
}
