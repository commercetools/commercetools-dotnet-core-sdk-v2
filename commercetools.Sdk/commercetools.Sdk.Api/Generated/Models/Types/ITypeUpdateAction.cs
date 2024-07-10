using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
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
    public partial interface ITypeUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Types.TypeAddEnumValueAction AddEnumValue(Action<commercetools.Sdk.Api.Models.Types.TypeAddEnumValueAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeAddEnumValueAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeAddFieldDefinitionAction AddFieldDefinition(Action<commercetools.Sdk.Api.Models.Types.TypeAddFieldDefinitionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeAddFieldDefinitionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeAddLocalizedEnumValueAction AddLocalizedEnumValue(Action<commercetools.Sdk.Api.Models.Types.TypeAddLocalizedEnumValueAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeAddLocalizedEnumValueAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeChangeEnumValueLabelAction ChangeEnumValueLabel(Action<commercetools.Sdk.Api.Models.Types.TypeChangeEnumValueLabelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeChangeEnumValueLabelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeChangeEnumValueOrderAction ChangeEnumValueOrder(Action<commercetools.Sdk.Api.Models.Types.TypeChangeEnumValueOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeChangeEnumValueOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeChangeFieldDefinitionOrderAction ChangeFieldDefinitionOrder(Action<commercetools.Sdk.Api.Models.Types.TypeChangeFieldDefinitionOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeChangeFieldDefinitionOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeChangeInputHintAction ChangeInputHint(Action<commercetools.Sdk.Api.Models.Types.TypeChangeInputHintAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeChangeInputHintAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeChangeKeyAction ChangeKey(Action<commercetools.Sdk.Api.Models.Types.TypeChangeKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeChangeKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeChangeLabelAction ChangeLabel(Action<commercetools.Sdk.Api.Models.Types.TypeChangeLabelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeChangeLabelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueLabelAction ChangeLocalizedEnumValueLabel(Action<commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueLabelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueLabelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueOrderAction ChangeLocalizedEnumValueOrder(Action<commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.Types.TypeChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeRemoveFieldDefinitionAction RemoveFieldDefinition(Action<commercetools.Sdk.Api.Models.Types.TypeRemoveFieldDefinitionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeRemoveFieldDefinitionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.Types.TypeSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
    }
}
