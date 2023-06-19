using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl
    {
        public TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl()
        {
        }

        public static TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl Of()
        {
            return new TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl>(p, TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl, string> FieldName()
        {
            return new ComparisonPredicateBuilder<TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldName")),
            p => new CombinationQueryPredicate<TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl>(p, TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl.Of())),
                TypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl.Of);
        }


    }
}
