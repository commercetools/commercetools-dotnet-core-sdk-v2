using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetImageLabelChange : ISetImageLabelChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string CatalogData { get; set;}
        
        public IImage PreviousValue { get; set;}
        
        public IImage NextValue { get; set;}
        public SetImageLabelChange()
        { 
           this.Type = "SetImageLabelChange";
        }
    }
}
