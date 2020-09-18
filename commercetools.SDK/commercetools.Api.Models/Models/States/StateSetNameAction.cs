using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("setName")]
    public class StateSetNameAction : StateUpdateAction
    {
        public LocalizedString Name { get; set;}
    }
}
