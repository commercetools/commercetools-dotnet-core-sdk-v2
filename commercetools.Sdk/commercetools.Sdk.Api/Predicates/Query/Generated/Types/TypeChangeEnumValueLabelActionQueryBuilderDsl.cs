using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeChangeEnumValueLabelActionQueryBuilderDsl
    {
        public TypeChangeEnumValueLabelActionQueryBuilderDsl()
        {
        }

        public static TypeChangeEnumValueLabelActionQueryBuilderDsl Of()
        {
            return new TypeChangeEnumValueLabelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeChangeEnumValueLabelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeChangeEnumValueLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeChangeEnumValueLabelActionQueryBuilderDsl>(p, TypeChangeEnumValueLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeChangeEnumValueLabelActionQueryBuilderDsl, string> FieldName()
        {
            return new ComparisonPredicateBuilder<TypeChangeEnumValueLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldName")),
            p => new CombinationQueryPredicate<TypeChangeEnumValueLabelActionQueryBuilderDsl>(p, TypeChangeEnumValueLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeChangeEnumValueLabelActionQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeChangeEnumValueLabelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumValueQueryBuilderDsl.Of())),
                TypeChangeEnumValueLabelActionQueryBuilderDsl.Of);
        }


    }
}
