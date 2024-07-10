using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeChangeKeyActionQueryBuilderDsl
    {
        public TypeChangeKeyActionQueryBuilderDsl()
        {
        }

        public static TypeChangeKeyActionQueryBuilderDsl Of()
        {
            return new TypeChangeKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeChangeKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeChangeKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeChangeKeyActionQueryBuilderDsl>(p, TypeChangeKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeChangeKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<TypeChangeKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<TypeChangeKeyActionQueryBuilderDsl>(p, TypeChangeKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
