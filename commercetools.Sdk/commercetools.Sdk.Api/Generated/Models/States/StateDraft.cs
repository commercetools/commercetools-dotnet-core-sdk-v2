using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
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
