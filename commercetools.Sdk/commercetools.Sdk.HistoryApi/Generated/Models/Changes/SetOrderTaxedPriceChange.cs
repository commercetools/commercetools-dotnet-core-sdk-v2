using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetOrderTaxedPriceChange : ISetOrderTaxedPriceChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ITaxMode TaxMode { get; set;}
        
        public ITaxedItemPrice NextValue { get; set;}
        
        public ITaxedItemPrice PreviousValue { get; set;}
        public SetOrderTaxedPriceChange()
        { 
           this.Type = "SetOrderTaxedPriceChange";
        }
    }
}
