using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.Reference))]
    public partial interface IReference 
    {
        string Id { get; set;}
        
        IReferenceTypeId TypeId { get; set;}
    }
}
