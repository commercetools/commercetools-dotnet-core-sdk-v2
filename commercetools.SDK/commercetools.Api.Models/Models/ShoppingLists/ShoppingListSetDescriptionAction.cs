using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setDescription")]
    public class ShoppingListSetDescriptionAction : ShoppingListUpdateAction
    {
        public LocalizedString Description { get; set;}
    }
}
