using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeTextLineItemName")]
    public partial class MyShoppingListChangeTextLineItemNameAction : MyShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public LocalizedString Name { get; set;}
        public MyShoppingListChangeTextLineItemNameAction()
        { 
           this.Action = "changeTextLineItemName";
        }
    }
}
