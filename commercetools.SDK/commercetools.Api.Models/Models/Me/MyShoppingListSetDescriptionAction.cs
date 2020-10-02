using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setDescription")]
    public partial class MyShoppingListSetDescriptionAction : MyShoppingListUpdateAction
    {
        public LocalizedString Description { get; set;}
        public MyShoppingListSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
