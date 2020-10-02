using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("changeKey")]
    public partial class StateChangeKeyAction : StateUpdateAction
    {
        public string Key { get; set;}
        public StateChangeKeyAction()
        { 
           this.Action = "changeKey";
        }
    }
}
