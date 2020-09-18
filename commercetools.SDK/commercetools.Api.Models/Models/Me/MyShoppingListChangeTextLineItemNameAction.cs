using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeTextLineItemName")]
    public class MyShoppingListChangeTextLineItemNameAction : MyShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public LocalizedString Name { get; set;}
    }
}
