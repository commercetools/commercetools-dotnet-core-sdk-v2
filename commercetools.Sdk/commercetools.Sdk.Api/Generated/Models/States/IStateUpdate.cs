using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateUpdate))]
    public partial interface IStateUpdate
    {
        long Version { get; set; }

        IList<IStateUpdateAction> Actions { get; set; }
        IEnumerable<IStateUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
