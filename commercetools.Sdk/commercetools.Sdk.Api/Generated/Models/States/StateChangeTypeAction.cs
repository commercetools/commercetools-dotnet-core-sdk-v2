using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    public  partial class StateChangeTypeAction : IStateChangeTypeAction
    {
        public string Action { get; set;}
        
        public string Type { get; set;}
        
        [JsonIgnore]
        public StateTypeEnum TypeAsEnum => this.Type.GetEnum<StateTypeEnum>();
        public StateChangeTypeAction()
        { 
           this.Action = "changeType";
        }
    }
}
