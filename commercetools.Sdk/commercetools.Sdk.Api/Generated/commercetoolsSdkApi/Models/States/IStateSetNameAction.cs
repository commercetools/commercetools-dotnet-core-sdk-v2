using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateSetNameAction))]
    public partial interface IStateSetNameAction : IStateUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
