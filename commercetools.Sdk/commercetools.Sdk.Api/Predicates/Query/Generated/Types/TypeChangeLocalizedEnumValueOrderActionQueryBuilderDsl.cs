using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl
    {
        public TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl()
        {
        }

        public static TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl Of()
        {
            return new TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl>(p, TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, string> FieldName()
        {
            return new ComparisonPredicateBuilder<TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldName")),
            p => new CombinationQueryPredicate<TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl>(p, TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, string> Keys()
        {
            return new ComparableCollectionPredicateBuilder<TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("keys")),
            p => new CombinationQueryPredicate<TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl>(p, TypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
