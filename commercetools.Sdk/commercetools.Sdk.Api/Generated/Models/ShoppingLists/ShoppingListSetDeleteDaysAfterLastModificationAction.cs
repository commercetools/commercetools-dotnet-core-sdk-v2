using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListSetDeleteDaysAfterLastModificationAction : IShoppingListSetDeleteDaysAfterLastModificationAction
    {
        public string Action { get; set; }

        public long? DeleteDaysAfterLastModification { get; set; }
        public ShoppingListSetDeleteDaysAfterLastModificationAction()
        {
            this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}
