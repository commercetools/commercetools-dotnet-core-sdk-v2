using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.AddFieldDefinitionChange))]
    public partial interface IAddFieldDefinitionChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IFieldDefinition NextValue { get; set;}
    }
}
