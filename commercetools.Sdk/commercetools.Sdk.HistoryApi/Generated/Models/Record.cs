using commercetools.HistoryApi.Models;
using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using commercetools.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models
{
    public partial class Record : IRecord
    {
        public int Version { get; set;}
        
        public int PreviousVersion { get; set;}
        
        public string Type { get; set;}
        
        public IModifiedBy ModifiedBy { get; set;}
        
        public string ModifiedAt { get; set;}
        
        public ILabel Label { get; set;}
        
        public ILabel PreviousLabel { get; set;}
        
        public List<IChange> Changes { get; set;}
        
        public IReference Resource { get; set;}
        
        public bool WithoutChanges { get; set;}
    }
}
