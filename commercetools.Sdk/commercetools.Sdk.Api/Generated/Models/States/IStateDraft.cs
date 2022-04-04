using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


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

        List<IStateRoleEnum> Roles { get; set; }

        List<IStateResourceIdentifier> Transitions { get; set; }
    }
}
