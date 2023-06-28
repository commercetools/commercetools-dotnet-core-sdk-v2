using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
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
    public partial interface IStateUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.States.StateAddRolesAction AddRoles(Action<commercetools.Sdk.Api.Models.States.StateAddRolesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.States.StateAddRolesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.States.StateChangeInitialAction ChangeInitial(Action<commercetools.Sdk.Api.Models.States.StateChangeInitialAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.States.StateChangeInitialAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.States.StateChangeKeyAction ChangeKey(Action<commercetools.Sdk.Api.Models.States.StateChangeKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.States.StateChangeKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.States.StateChangeTypeAction ChangeType(Action<commercetools.Sdk.Api.Models.States.StateChangeTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.States.StateChangeTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.States.StateRemoveRolesAction RemoveRoles(Action<commercetools.Sdk.Api.Models.States.StateRemoveRolesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.States.StateRemoveRolesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.States.StateSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.States.StateSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.States.StateSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.States.StateSetNameAction SetName(Action<commercetools.Sdk.Api.Models.States.StateSetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.States.StateSetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.States.StateSetRolesAction SetRoles(Action<commercetools.Sdk.Api.Models.States.StateSetRolesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.States.StateSetRolesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.States.StateSetTransitionsAction SetTransitions(Action<commercetools.Sdk.Api.Models.States.StateSetTransitionsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.States.StateSetTransitionsAction();
            init?.Invoke(t);
            return t;
        }
    }
}
