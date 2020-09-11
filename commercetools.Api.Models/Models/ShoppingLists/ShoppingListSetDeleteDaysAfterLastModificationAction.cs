using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingListSetDeleteDaysAfterLastModificationAction : ShoppingListUpdateAction
    {
        public long DeleteDaysAfterLastModification { get; set;}
    }
}
