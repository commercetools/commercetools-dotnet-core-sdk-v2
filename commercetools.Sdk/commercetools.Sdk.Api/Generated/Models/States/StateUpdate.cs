using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.States
{

    public partial class StateUpdate : IStateUpdate
    {
        public long Version { get; set; }

        public IList<IStateUpdateAction> Actions { get; set; }
        public IEnumerable<IStateUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
