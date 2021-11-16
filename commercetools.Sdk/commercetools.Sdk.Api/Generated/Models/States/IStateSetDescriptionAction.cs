using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateSetDescriptionAction))]
    public partial interface IStateSetDescriptionAction : IStateUpdateAction
    {
        ILocalizedString Description { get; set; }
    }
}
