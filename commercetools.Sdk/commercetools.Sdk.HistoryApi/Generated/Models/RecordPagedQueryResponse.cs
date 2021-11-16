using commercetools.HistoryApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models
{
    public partial class RecordPagedQueryResponse : IRecordPagedQueryResponse
    {
        public int Limit { get; set;}
        
        public int Count { get; set;}
        
        public int Total { get; set;}
        
        public int Offset { get; set;}
        
        public List<IRecord> Results { get; set;}
    }
}
