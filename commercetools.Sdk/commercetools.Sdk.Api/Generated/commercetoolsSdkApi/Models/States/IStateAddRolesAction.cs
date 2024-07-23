using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
