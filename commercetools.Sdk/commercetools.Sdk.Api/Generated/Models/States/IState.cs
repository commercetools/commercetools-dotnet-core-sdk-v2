using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.State))]
    public partial interface IState : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        IStateTypeEnum Type { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        bool Initial { get; set; }

        bool BuiltIn { get; set; }

        IList<IStateRoleEnum> Roles { get; set; }
        IEnumerable<IStateRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }


        IList<IStateReference> Transitions { get; set; }
        IEnumerable<IStateReference> TransitionsEnumerable { set => Transitions = value.ToList(); }


    }
}
