using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeUpdateAction))]
    [SubTypeDiscriminator("addAttributeDefinition", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddAttributeDefinitionAction))]
    [SubTypeDiscriminator("addLocalizedEnumValue", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddLocalizedEnumValueAction))]
    [SubTypeDiscriminator("addPlainEnumValue", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddPlainEnumValueAction))]
    [SubTypeDiscriminator("changeAttributeConstraint", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeConstraintAction))]
    [SubTypeDiscriminator("changeAttributeName", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeNameAction))]
    [SubTypeDiscriminator("changeAttributeOrderByName", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderByNameAction))]
    [SubTypeDiscriminator("changeDescription", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeDescriptionAction))]
    [SubTypeDiscriminator("changeEnumKey", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeEnumKeyAction))]
    [SubTypeDiscriminator("changeInputHint", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeInputHintAction))]
    [SubTypeDiscriminator("changeIsSearchable", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeIsSearchableAction))]
    [SubTypeDiscriminator("changeLabel", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLabelAction))]
    [SubTypeDiscriminator("changeLocalizedEnumValueLabel", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelAction))]
    [SubTypeDiscriminator("changeLocalizedEnumValueOrder", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeNameAction))]
    [SubTypeDiscriminator("changePlainEnumValueLabel", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueLabelAction))]
    [SubTypeDiscriminator("changePlainEnumValueOrder", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueOrderAction))]
    [SubTypeDiscriminator("removeAttributeDefinition", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveAttributeDefinitionAction))]
    [SubTypeDiscriminator("removeEnumValues", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveEnumValuesAction))]
    [SubTypeDiscriminator("setInputTip", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetInputTipAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetKeyAction))]
    public partial interface IProductTypeUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IProductTypeUpdateAction>
    {
        new string Action { get; set; }

        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddAttributeDefinitionAction AddAttributeDefinition(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddAttributeDefinitionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddAttributeDefinitionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddLocalizedEnumValueAction AddLocalizedEnumValue(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddLocalizedEnumValueAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddLocalizedEnumValueAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddPlainEnumValueAction AddPlainEnumValue(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddPlainEnumValueAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddPlainEnumValueAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeConstraintAction ChangeAttributeConstraint(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeConstraintAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeConstraintAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeNameAction ChangeAttributeName(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderByNameAction ChangeAttributeOrderByName(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderByNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderByNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeDescriptionAction ChangeDescription(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeEnumKeyAction ChangeEnumKey(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeEnumKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeEnumKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeInputHintAction ChangeInputHint(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeInputHintAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeInputHintAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeIsSearchableAction ChangeIsSearchable(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeIsSearchableAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeIsSearchableAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLabelAction ChangeLabel(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLabelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLabelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelAction ChangeLocalizedEnumValueLabel(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderAction ChangeLocalizedEnumValueOrder(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueLabelAction ChangePlainEnumValueLabel(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueLabelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueLabelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueOrderAction ChangePlainEnumValueOrder(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveAttributeDefinitionAction RemoveAttributeDefinition(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveAttributeDefinitionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveAttributeDefinitionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveEnumValuesAction RemoveEnumValues(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveEnumValuesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveEnumValuesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetInputTipAction SetInputTip(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetInputTipAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetInputTipAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetKeyAction();
            init?.Invoke(t);
            return t;
        }
    }
}
