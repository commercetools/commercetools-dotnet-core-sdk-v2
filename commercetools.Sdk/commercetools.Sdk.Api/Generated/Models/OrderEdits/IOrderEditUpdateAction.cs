using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditUpdateAction))]
    [SubTypeDiscriminator("addStagedAction", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditAddStagedActionAction))]
    [SubTypeDiscriminator("setComment", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCommentAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCustomTypeAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetKeyAction))]
    [SubTypeDiscriminator("setStagedActions", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetStagedActionsAction))]
    public partial interface IOrderEditUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditAddStagedActionAction AddStagedAction(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditAddStagedActionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditAddStagedActionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCommentAction SetComment(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCommentAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCommentAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetStagedActionsAction SetStagedActions(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetStagedActionsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetStagedActionsAction();
            init?.Invoke(t);
            return t;
        }
    }
}
