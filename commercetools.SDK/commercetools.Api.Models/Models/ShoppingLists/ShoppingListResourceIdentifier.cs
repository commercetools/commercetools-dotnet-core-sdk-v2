using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("shopping-list")]
    public partial class ShoppingListResourceIdentifier : ResourceIdentifier
    {
        public ShoppingListResourceIdentifier()
        { 
           this.TypeId = "shopping-list";
        }
    }
}
