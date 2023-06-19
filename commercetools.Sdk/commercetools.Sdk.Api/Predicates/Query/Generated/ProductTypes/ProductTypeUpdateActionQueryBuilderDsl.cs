using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeUpdateActionQueryBuilderDsl
    {
        public ProductTypeUpdateActionQueryBuilderDsl()
        {
        }

        public static ProductTypeUpdateActionQueryBuilderDsl Of()
        {
            return new ProductTypeUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(p, ProductTypeUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsAddAttributeDefinition(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeAddAttributeDefinitionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeAddAttributeDefinitionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeAddAttributeDefinitionActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsAddLocalizedEnumValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsAddPlainEnumValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeAddPlainEnumValueActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeAddPlainEnumValueActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeAddPlainEnumValueActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangeAttributeConstraint(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeAttributeConstraintActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeAttributeConstraintActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeAttributeConstraintActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangeAttributeName(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeAttributeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeAttributeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeAttributeNameActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangeAttributeOrderByName(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangeDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeDescriptionActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangeEnumKey(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeEnumKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeEnumKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeEnumKeyActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangeInputHint(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeInputHintActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeInputHintActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeInputHintActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangeIsSearchable(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeIsSearchableActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeIsSearchableActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeIsSearchableActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangeLabel(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeLabelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeLabelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeLabelActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangeLocalizedEnumValueLabel(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangeLocalizedEnumValueOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangeNameActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangePlainEnumValueLabel(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsChangePlainEnumValueOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsRemoveAttributeDefinition(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeRemoveAttributeDefinitionActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsRemoveEnumValues(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeRemoveEnumValuesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeRemoveEnumValuesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeRemoveEnumValuesActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsSetInputTip(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeSetInputTipActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeSetInputTipActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeSetInputTipActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeSetKeyActionQueryBuilderDsl.Of()),
                ProductTypeUpdateActionQueryBuilderDsl.Of);
        }
    }
}
