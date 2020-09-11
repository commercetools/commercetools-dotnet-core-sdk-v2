using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.States
{
    public class StateSetNameAction : StateUpdateAction
    {
        public LocalizedString Name { get; set;}
    }
}
