using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeShoppingListLineItemQuantityChange : IChangeShoppingListLineItemQuantityChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public int PreviousValue { get; set; }

        public int NextValue { get; set; }

        public IShoppingListLineItemValue LineItem { get; set; }
        public ChangeShoppingListLineItemQuantityChange()
        {
            this.Type = "ChangeShoppingListLineItemQuantityChange";
        }
    }
}
