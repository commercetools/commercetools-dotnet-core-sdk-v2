using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeModel : IChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
    }
}
