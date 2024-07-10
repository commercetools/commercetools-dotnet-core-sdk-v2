using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeAddEnumValueActionQueryBuilderDsl
    {
        public TypeAddEnumValueActionQueryBuilderDsl()
        {
        }

        public static TypeAddEnumValueActionQueryBuilderDsl Of()
        {
            return new TypeAddEnumValueActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeAddEnumValueActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeAddEnumValueActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeAddEnumValueActionQueryBuilderDsl>(p, TypeAddEnumValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeAddEnumValueActionQueryBuilderDsl, string> FieldName()
        {
            return new ComparisonPredicateBuilder<TypeAddEnumValueActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldName")),
            p => new CombinationQueryPredicate<TypeAddEnumValueActionQueryBuilderDsl>(p, TypeAddEnumValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeAddEnumValueActionQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeAddEnumValueActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumValueQueryBuilderDsl.Of())),
                TypeAddEnumValueActionQueryBuilderDsl.Of);
        }


    }
}
