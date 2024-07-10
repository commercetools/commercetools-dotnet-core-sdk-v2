using commercetools.Sdk.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShoppingLists
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
