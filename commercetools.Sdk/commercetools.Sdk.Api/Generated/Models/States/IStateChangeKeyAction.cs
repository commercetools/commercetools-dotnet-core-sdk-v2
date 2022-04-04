using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.States.StateChangeKeyAction))]
    public partial interface IStateChangeKeyAction : IStateUpdateAction
    {
        string Key { get; set; }
    }
}
