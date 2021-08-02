using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class UpdateSyncInfoChange : IUpdateSyncInfoChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string ChannelId { get; set;}
        
        public ISyncInfo NextValue { get; set;}
        public UpdateSyncInfoChange()
        { 
           this.Type = "UpdateSyncInfoChange";
        }
    }
}
