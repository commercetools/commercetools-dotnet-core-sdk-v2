using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetPricesChange))]
    public partial interface ISetPricesChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string CatalogData { get; set;}
        
        string Variant { get; set;}
        
        List<IPrice> PreviousValue { get; set;}
        
        List<IPrice> NextValue { get; set;}
    }
}
