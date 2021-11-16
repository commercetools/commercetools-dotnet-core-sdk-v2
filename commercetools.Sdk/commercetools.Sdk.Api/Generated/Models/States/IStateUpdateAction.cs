using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.States.StateUpdateAction))]
    [SubTypeDiscriminator("addRoles", typeof(commercetools.Api.Models.States.StateAddRolesAction))]
    [SubTypeDiscriminator("changeInitial", typeof(commercetools.Api.Models.States.StateChangeInitialAction))]
    [SubTypeDiscriminator("changeKey", typeof(commercetools.Api.Models.States.StateChangeKeyAction))]
    [SubTypeDiscriminator("changeType", typeof(commercetools.Api.Models.States.StateChangeTypeAction))]
    [SubTypeDiscriminator("removeRoles", typeof(commercetools.Api.Models.States.StateRemoveRolesAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.States.StateSetDescriptionAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Api.Models.States.StateSetNameAction))]
    [SubTypeDiscriminator("setRoles", typeof(commercetools.Api.Models.States.StateSetRolesAction))]
    [SubTypeDiscriminator("setTransitions", typeof(commercetools.Api.Models.States.StateSetTransitionsAction))]
    public partial interface IStateUpdateAction 
    {
        string Action { get; set;}
    }
}
