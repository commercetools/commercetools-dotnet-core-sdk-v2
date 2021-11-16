using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateChangeInitialAction))]
    public partial interface IStateChangeInitialAction : IStateUpdateAction
    {
        bool Initial { get; set;}
    }
}
