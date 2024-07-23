using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


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
