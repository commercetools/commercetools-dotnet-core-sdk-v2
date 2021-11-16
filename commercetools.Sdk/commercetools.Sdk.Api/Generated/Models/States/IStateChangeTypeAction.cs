using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateChangeTypeAction))]
    public partial interface IStateChangeTypeAction : IStateUpdateAction
    {
        IStateTypeEnum Type { get; set;}
    }
}
