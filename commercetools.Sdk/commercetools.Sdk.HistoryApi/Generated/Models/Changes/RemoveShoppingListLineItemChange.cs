using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveShoppingListLineItemChange : IRemoveShoppingListLineItemChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ILineItem PreviousValue { get; set;}
        
        public ILineItem NextValue { get; set;}
        public RemoveShoppingListLineItemChange()
        { 
           this.Type = "RemoveShoppingListLineItemChange";
        }
    }
}
