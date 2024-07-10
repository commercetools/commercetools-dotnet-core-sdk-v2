using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateDraft))]
    public partial interface IStateDraft
    {
        string Key { get; set; }

        IStateTypeEnum Type { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        bool? Initial { get; set; }

        IList<IStateRoleEnum> Roles { get; set; }
        IEnumerable<IStateRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }


        IList<IStateResourceIdentifier> Transitions { get; set; }
        IEnumerable<IStateResourceIdentifier> TransitionsEnumerable { set => Transitions = value.ToList(); }


    }
}
