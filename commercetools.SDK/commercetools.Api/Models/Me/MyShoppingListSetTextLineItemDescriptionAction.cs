using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setTextLineItemDescription")]
    public partial class MyShoppingListSetTextLineItemDescriptionAction : MyShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public LocalizedString Description { get; set;}
        public MyShoppingListSetTextLineItemDescriptionAction()
        { 
           this.Action = "setTextLineItemDescription";
        }
    }
}
