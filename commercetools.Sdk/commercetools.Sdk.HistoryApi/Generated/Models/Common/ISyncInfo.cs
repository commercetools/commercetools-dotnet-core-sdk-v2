using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.SyncInfo))]
    public partial interface ISyncInfo 
    {
        IReference Channel { get; set;}
        
        string ExternalId { get; set;}
        
        string SyncedAt { get; set;}
    }
}