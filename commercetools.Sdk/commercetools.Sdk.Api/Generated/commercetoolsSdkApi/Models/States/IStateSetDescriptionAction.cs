using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateSetDescriptionAction))]
    public partial interface IStateSetDescriptionAction : IStateUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
