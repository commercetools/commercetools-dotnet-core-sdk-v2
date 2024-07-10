using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.States
{

    public partial class StateDraft : IStateDraft
    {
        public string Key { get; set; }

        public IStateTypeEnum Type { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public bool? Initial { get; set; }

        public IList<IStateRoleEnum> Roles { get; set; }
        public IEnumerable<IStateRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }


        public IList<IStateResourceIdentifier> Transitions { get; set; }
        public IEnumerable<IStateResourceIdentifier> TransitionsEnumerable { set => Transitions = value.ToList(); }

    }
}
