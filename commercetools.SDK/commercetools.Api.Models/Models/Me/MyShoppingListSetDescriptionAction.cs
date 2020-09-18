using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setDescription")]
    public class MyShoppingListSetDescriptionAction : MyShoppingListUpdateAction
    {
        public LocalizedString Description { get; set;}
    }
}
