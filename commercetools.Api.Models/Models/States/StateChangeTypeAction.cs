using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.States
{
    public class StateChangeTypeAction : StateUpdateAction
    {
        public StateTypeEnum Type { get; set;}
    }
}
