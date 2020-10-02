using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setSlug")]
    public partial class ShoppingListSetSlugAction : ShoppingListUpdateAction
    {
        public LocalizedString Slug { get; set;}
        public ShoppingListSetSlugAction()
        { 
           this.Action = "setSlug";
        }
    }
}
