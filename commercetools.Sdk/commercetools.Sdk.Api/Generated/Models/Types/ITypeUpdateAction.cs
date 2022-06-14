using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Types.TypeUpdateAction))]
    [SubTypeDiscriminator("addEnumValue", typeof(commercetools.Sdk.Api.Models.Types.TypeAddEnumValueAction))]
    [SubTypeDiscriminator("addFieldDefinition", typeof(commercetools.Sdk.Api.Models.Types.TypeAddFieldDefinitionAction))]
    [SubTypeDiscriminator("addLocalizedEnumValue", typeof(commercetools.Sdk.Api.Models.Types.TypeAddLocalizedEnumValueAction))]
    [SubTypeDiscriminator("changeEnumValueLabel", typeof(commercetools.Sdk.Api.Models.Types.TypeChangeEnumValueLabelAction))]
    [SubTypeDiscriminator("changeEnumValueOrder", typeof(commercetools.Sdk.Api.Models.Types.TypeChangeEnumValueOrderAction))]
    [SubTypeDiscriminator("changeFieldDefinitionOrder", typeof(commercetools.Sdk.Api.Models.Types.TypeChangeFieldDefinitionOrderAction))]
    [SubTypeDiscriminator("changeInputHint", typeof(commercetools.Sdk.Api.Models.Types.TypeChangeInputHintAction))]
    [SubTypeDiscriminator("changeKey", typeof(commercetools.Sdk.Api.Models.Types.TypeChangeKeyAction))]
    [SubTypeDiscriminator("changeLabel", typeof(commercetools.Sdk.Api.Models.Types.TypeChangeLabelAction))]
    [SubTypeDiscriminator("changeLocalizedEnumValueLabel", typeof(commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueLabelAction))]
    [SubTypeDiscriminator("changeLocalizedEnumValueOrder", typeof(commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueOrderAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.Types.TypeChangeNameAction))]
    [SubTypeDiscriminator("removeFieldDefinition", typeof(commercetools.Sdk.Api.Models.Types.TypeRemoveFieldDefinitionAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.Types.TypeSetDescriptionAction))]
    public partial interface ITypeUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<ITypeUpdateAction>
    {
        new string Action { get; set; }
    }
}
