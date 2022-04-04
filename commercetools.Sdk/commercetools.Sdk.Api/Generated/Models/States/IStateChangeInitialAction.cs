using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateChangeInitialAction))]
    public partial interface IStateChangeInitialAction : IStateUpdateAction
    {
        bool Initial { get; set; }
    }
}
