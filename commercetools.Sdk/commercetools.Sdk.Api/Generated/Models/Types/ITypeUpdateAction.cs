using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addEnumValue", typeof(commercetools.Api.Models.Types.TypeAddEnumValueAction))]
    [SubTypeDiscriminator("addFieldDefinition", typeof(commercetools.Api.Models.Types.TypeAddFieldDefinitionAction))]
    [SubTypeDiscriminator("addLocalizedEnumValue", typeof(commercetools.Api.Models.Types.TypeAddLocalizedEnumValueAction))]
    [SubTypeDiscriminator("changeEnumValueLabel", typeof(commercetools.Api.Models.Types.TypeChangeEnumValueLabelAction))]
    [SubTypeDiscriminator("changeEnumValueOrder", typeof(commercetools.Api.Models.Types.TypeChangeEnumValueOrderAction))]
    [SubTypeDiscriminator("changeFieldDefinitionLabel", typeof(commercetools.Api.Models.Types.TypeChangeFieldDefinitionLabelAction))]
    [SubTypeDiscriminator("changeFieldDefinitionOrder", typeof(commercetools.Api.Models.Types.TypeChangeFieldDefinitionOrderAction))]
    [SubTypeDiscriminator("changeInputHint", typeof(commercetools.Api.Models.Types.TypeChangeInputHintAction))]
    [SubTypeDiscriminator("changeKey", typeof(commercetools.Api.Models.Types.TypeChangeKeyAction))]
    [SubTypeDiscriminator("changeLabel", typeof(commercetools.Api.Models.Types.TypeChangeLabelAction))]
    [SubTypeDiscriminator("changeLocalizedEnumValueLabel", typeof(commercetools.Api.Models.Types.TypeChangeLocalizedEnumValueLabelAction))]
    [SubTypeDiscriminator("changeLocalizedEnumValueOrder", typeof(commercetools.Api.Models.Types.TypeChangeLocalizedEnumValueOrderAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.Types.TypeChangeNameAction))]
    [SubTypeDiscriminator("removeFieldDefinition", typeof(commercetools.Api.Models.Types.TypeRemoveFieldDefinitionAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.Types.TypeSetDescriptionAction))]
    public interface ITypeUpdateAction 
    {
        string Action { get; set;}
    }
}
