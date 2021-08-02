using commercetools.HistoryApi.Models.Common;
using commercetools.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    public partial class LocalizedLabel : ILocalizedLabel
    {
        public string Type { get; set;}
        
        public ILocalizedString Value { get; set;}
        public LocalizedLabel()
        { 
           this.Type = "LocalizedLabel";
        }
    }
}
