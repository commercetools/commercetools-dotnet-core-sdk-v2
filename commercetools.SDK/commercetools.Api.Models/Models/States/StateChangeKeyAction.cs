using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("changeKey")]
    public class StateChangeKeyAction : StateUpdateAction
    {
        public string Key { get; set;}
    }
}
