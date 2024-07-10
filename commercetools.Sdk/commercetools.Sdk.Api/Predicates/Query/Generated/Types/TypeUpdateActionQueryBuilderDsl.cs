using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeUpdateActionQueryBuilderDsl
    {
        public TypeUpdateActionQueryBuilderDsl()
        {
        }

        public static TypeUpdateActionQueryBuilderDsl Of()
        {
            return new TypeUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(p, TypeUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsAddEnumValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeAddEnumValueActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeAddEnumValueActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeAddEnumValueActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsAddFieldDefinition(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeAddFieldDefinitionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeAddFieldDefinitionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeAddFieldDefinitionActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsAddLocalizedEnumValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeAddLocalizedEnumValueActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeAddLocalizedEnumValueActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeAddLocalizedEnumValueActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsChangeEnumValueLabel(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeEnumValueLabelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeEnumValueLabelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeEnumValueLabelActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsChangeEnumValueOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeEnumValueOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeEnumValueOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeEnumValueOrderActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsChangeFieldDefinitionOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeFieldDefinitionOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeFieldDefinitionOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeFieldDefinitionOrderActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsChangeInputHint(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeInputHintActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeInputHintActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeInputHintActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsChangeKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeKeyActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsChangeLabel(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeLabelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeLabelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeLabelActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsChangeLocalizedEnumValueLabel(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsChangeLocalizedEnumValueOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeChangeNameActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsRemoveFieldDefinition(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeRemoveFieldDefinitionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeRemoveFieldDefinitionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeRemoveFieldDefinitionActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeSetDescriptionActionQueryBuilderDsl.Of()),
                TypeUpdateActionQueryBuilderDsl.Of);
        }
    }
}
