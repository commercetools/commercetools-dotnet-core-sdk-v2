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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateAddRolesAction))]
    public partial interface IStateAddRolesAction : IStateUpdateAction
    {
        IList<IStateRoleEnum> Roles { get; set; }
        IEnumerable<IStateRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }


    }
}
