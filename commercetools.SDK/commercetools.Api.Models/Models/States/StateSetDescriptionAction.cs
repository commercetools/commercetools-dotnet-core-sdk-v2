using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("setDescription")]
    public partial class StateSetDescriptionAction : StateUpdateAction
    {
        public LocalizedString Description { get; set;}
        public StateSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
