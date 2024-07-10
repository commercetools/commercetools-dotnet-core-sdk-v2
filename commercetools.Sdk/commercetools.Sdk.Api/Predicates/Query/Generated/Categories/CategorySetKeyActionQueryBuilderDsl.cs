using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetKeyActionQueryBuilderDsl
    {
        public CategorySetKeyActionQueryBuilderDsl()
        {
        }

        public static CategorySetKeyActionQueryBuilderDsl Of()
        {
            return new CategorySetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetKeyActionQueryBuilderDsl>(p, CategorySetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CategorySetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CategorySetKeyActionQueryBuilderDsl>(p, CategorySetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
