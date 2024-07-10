using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.States
{

    public partial class StateChangeTypeAction : IStateChangeTypeAction
    {
        public string Action { get; set; }

        public IStateTypeEnum Type { get; set; }
        public StateChangeTypeAction()
        {
            this.Action = "changeType";
        }
    }
}
