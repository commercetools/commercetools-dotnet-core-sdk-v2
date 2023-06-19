using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeAddLocalizedEnumValueActionQueryBuilderDsl
    {
        public TypeAddLocalizedEnumValueActionQueryBuilderDsl()
        {
        }

        public static TypeAddLocalizedEnumValueActionQueryBuilderDsl Of()
        {
            return new TypeAddLocalizedEnumValueActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeAddLocalizedEnumValueActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeAddLocalizedEnumValueActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeAddLocalizedEnumValueActionQueryBuilderDsl>(p, TypeAddLocalizedEnumValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeAddLocalizedEnumValueActionQueryBuilderDsl, string> FieldName()
        {
            return new ComparisonPredicateBuilder<TypeAddLocalizedEnumValueActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldName")),
            p => new CombinationQueryPredicate<TypeAddLocalizedEnumValueActionQueryBuilderDsl>(p, TypeAddLocalizedEnumValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeAddLocalizedEnumValueActionQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeAddLocalizedEnumValueActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl.Of())),
                TypeAddLocalizedEnumValueActionQueryBuilderDsl.Of);
        }


    }
}
