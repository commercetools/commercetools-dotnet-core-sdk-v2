using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.EnumValue))]
    public partial interface IEnumValue 
    {
        string Key { get; set;}
        
        string Label { get; set;}
    }
}
