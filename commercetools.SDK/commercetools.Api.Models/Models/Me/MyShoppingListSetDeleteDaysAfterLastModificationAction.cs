using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setDeleteDaysAfterLastModification")]
    public class MyShoppingListSetDeleteDaysAfterLastModificationAction : MyShoppingListUpdateAction
    {
        public long DeleteDaysAfterLastModification { get; set;}
    }
}
