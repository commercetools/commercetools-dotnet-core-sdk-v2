using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setDescription")]
    public partial class ShoppingListSetDescriptionAction : ShoppingListUpdateAction
    {
        public LocalizedString Description { get; set;}
        public ShoppingListSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
