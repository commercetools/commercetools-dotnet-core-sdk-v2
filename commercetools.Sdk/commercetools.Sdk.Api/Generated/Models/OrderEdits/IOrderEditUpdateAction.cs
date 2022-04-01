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
    }
}
