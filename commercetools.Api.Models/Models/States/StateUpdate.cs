using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.States
{
    public class StateUpdate 
    {
        public long Version { get; set;}
        
        public List<StateUpdateAction> Actions { get; set;}
    }
}
