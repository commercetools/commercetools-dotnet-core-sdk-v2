using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [Discriminator(nameof(Action))]
    public abstract class StateUpdateAction 
    {
        public string Action { get; set;}
    }
}
