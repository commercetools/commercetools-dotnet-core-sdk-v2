using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateChangeTypeAction))]
    public partial interface IStateChangeTypeAction : IStateUpdateAction
    {
        IStateTypeEnum Type { get; set; }
    }
}
