using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeCustomLineItemQuantityChange : IChangeCustomLineItemQuantityChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ILocalizedString CustomLineItem { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public int NextValue { get; set;}
        
        public int PreviousValue { get; set;}
        public ChangeCustomLineItemQuantityChange()
        { 
           this.Type = "ChangeCustomLineItemQuantityChange";
        }
    }
}
