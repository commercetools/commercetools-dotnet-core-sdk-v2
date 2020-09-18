using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setTextLineItemDescription")]
    public class MyShoppingListSetTextLineItemDescriptionAction : MyShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public LocalizedString Description { get; set;}
    }
}
