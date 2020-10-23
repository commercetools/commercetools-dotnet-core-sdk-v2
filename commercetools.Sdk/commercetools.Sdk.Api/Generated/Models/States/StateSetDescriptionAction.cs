using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    public  partial class StateSetDescriptionAction : IStateSetDescriptionAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Description { get; set;}
        public StateSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
