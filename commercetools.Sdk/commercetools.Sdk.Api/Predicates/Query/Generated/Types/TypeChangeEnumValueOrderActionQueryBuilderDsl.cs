using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeChangeEnumValueOrderActionQueryBuilderDsl
    {
        public TypeChangeEnumValueOrderActionQueryBuilderDsl()
        {
        }

        public static TypeChangeEnumValueOrderActionQueryBuilderDsl Of()
        {
            return new TypeChangeEnumValueOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeChangeEnumValueOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeChangeEnumValueOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeChangeEnumValueOrderActionQueryBuilderDsl>(p, TypeChangeEnumValueOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeChangeEnumValueOrderActionQueryBuilderDsl, string> FieldName()
        {
            return new ComparisonPredicateBuilder<TypeChangeEnumValueOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldName")),
            p => new CombinationQueryPredicate<TypeChangeEnumValueOrderActionQueryBuilderDsl>(p, TypeChangeEnumValueOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<TypeChangeEnumValueOrderActionQueryBuilderDsl, string> Keys()
        {
            return new ComparableCollectionPredicateBuilder<TypeChangeEnumValueOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("keys")),
            p => new CombinationQueryPredicate<TypeChangeEnumValueOrderActionQueryBuilderDsl>(p, TypeChangeEnumValueOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
