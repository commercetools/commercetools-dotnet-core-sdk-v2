using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.States
{
    public partial class StateDraft : IStateDraft
    {
        public string Key { get; set; }

        public IStateTypeEnum Type { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public bool? Initial { get; set; }

        public List<IStateRoleEnum> Roles { get; set; }

        public List<IStateResourceIdentifier> Transitions { get; set; }
    }
}
