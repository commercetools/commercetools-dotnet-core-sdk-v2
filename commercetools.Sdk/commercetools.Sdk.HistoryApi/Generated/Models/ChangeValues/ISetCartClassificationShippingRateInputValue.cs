using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.SetCartClassificationShippingRateInputValue))]
    public partial interface ISetCartClassificationShippingRateInputValue 
    {
        string Type { get; set;}
        
        string Key { get; set;}
        
        ILocalizedString Label { get; set;}
    }
}
