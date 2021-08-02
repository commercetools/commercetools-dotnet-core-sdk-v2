using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetShoppingListLineItemCustomTypeChange : ISetShoppingListLineItemCustomTypeChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IShoppingListLineItemValue LineItem { get; set;}
        
        public ICustomFields NextValue { get; set;}
        
        public ICustomFields PreviousValue { get; set;}
        public SetShoppingListLineItemCustomTypeChange()
        { 
           this.Type = "SetShoppingListLineItemCustomTypeChange";
        }
    }
}
