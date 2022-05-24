using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.States
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.States.StateUpdateAction))]
    [SubTypeDiscriminator("addRoles", typeof(commercetools.Sdk.Api.Models.States.StateAddRolesAction))]
    [SubTypeDiscriminator("changeInitial", typeof(commercetools.Sdk.Api.Models.States.StateChangeInitialAction))]
    [SubTypeDiscriminator("changeKey", typeof(commercetools.Sdk.Api.Models.States.StateChangeKeyAction))]
    [SubTypeDiscriminator("changeType", typeof(commercetools.Sdk.Api.Models.States.StateChangeTypeAction))]
    [SubTypeDiscriminator("removeRoles", typeof(commercetools.Sdk.Api.Models.States.StateRemoveRolesAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.States.StateSetDescriptionAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.States.StateSetNameAction))]
    [SubTypeDiscriminator("setRoles", typeof(commercetools.Sdk.Api.Models.States.StateSetRolesAction))]
    [SubTypeDiscriminator("setTransitions", typeof(commercetools.Sdk.Api.Models.States.StateSetTransitionsAction))]
    public partial interface IStateUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IStateUpdateAction>
    {
        new string Action { get; set; }
    }
}
