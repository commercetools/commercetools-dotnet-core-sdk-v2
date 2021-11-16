using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateChangeKeyAction))]
    public partial interface IStateChangeKeyAction : IStateUpdateAction
    {
        string Key { get; set;}
    }
}
