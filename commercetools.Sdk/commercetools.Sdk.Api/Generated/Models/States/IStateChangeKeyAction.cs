using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateChangeKeyAction))]
    public partial interface IStateChangeKeyAction : IStateUpdateAction
    {
        string Key { get; set; }
    }
}
