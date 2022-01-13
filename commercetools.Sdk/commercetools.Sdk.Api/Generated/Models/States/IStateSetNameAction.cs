using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateSetNameAction))]
    public partial interface IStateSetNameAction : IStateUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
