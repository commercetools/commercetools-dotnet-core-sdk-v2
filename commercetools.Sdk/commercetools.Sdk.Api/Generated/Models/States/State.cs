using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.States
{

    public partial class State : IState
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public IStateTypeEnum Type { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public bool Initial { get; set; }

        public bool BuiltIn { get; set; }

        public IList<IStateRoleEnum> Roles { get; set; }
        public IEnumerable<IStateRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }


        public IList<IStateReference> Transitions { get; set; }
        public IEnumerable<IStateReference> TransitionsEnumerable { set => Transitions = value.ToList(); }

    }
}
