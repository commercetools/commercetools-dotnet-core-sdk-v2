using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("setName")]
    public partial class StateSetNameAction : StateUpdateAction
    {
        public LocalizedString Name { get; set;}
        public StateSetNameAction()
        { 
           this.Action = "setName";
        }
    }
}
