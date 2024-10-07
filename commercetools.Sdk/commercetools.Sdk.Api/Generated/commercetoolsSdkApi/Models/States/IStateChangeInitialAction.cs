using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateChangeInitialAction))]
    public partial interface IStateChangeInitialAction : IStateUpdateAction
    {
        bool Initial { get; set; }

    }
}
