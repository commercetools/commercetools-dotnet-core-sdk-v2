using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddInterfaceInteractionChange : IAddInterfaceInteractionChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ICustomFieldExpandedValue NextValue { get; set;}
        public AddInterfaceInteractionChange()
        { 
           this.Type = "AddInterfaceInteractionChange";
        }
    }
}
