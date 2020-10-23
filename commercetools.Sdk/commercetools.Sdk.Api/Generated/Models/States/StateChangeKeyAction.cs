using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    public  partial class StateChangeKeyAction : IStateChangeKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public StateChangeKeyAction()
        { 
           this.Action = "changeKey";
        }
    }
}
