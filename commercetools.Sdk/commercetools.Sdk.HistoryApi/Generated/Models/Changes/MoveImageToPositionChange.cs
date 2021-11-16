using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class MoveImageToPositionChange : IMoveImageToPositionChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string CatalogData { get; set;}
        
        public List<IImage> PreviousValue { get; set;}
        
        public List<IImage> NextValue { get; set;}
        public MoveImageToPositionChange()
        { 
           this.Type = "MoveImageToPositionChange";
        }
    }
}
