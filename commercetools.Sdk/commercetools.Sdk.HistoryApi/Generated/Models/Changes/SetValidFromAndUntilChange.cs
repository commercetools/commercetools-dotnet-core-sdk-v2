using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetValidFromAndUntilChange : ISetValidFromAndUntilChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IValidFromAndUntilValue PreviousValue { get; set;}
        
        public IValidFromAndUntilValue NextValue { get; set;}
        public SetValidFromAndUntilChange()
        { 
           this.Type = "SetValidFromAndUntilChange";
        }
    }
}
