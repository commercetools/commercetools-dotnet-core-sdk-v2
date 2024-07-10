using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetExternalIdActionQueryBuilderDsl
    {
        public CategorySetExternalIdActionQueryBuilderDsl()
        {
        }

        public static CategorySetExternalIdActionQueryBuilderDsl Of()
        {
            return new CategorySetExternalIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetExternalIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetExternalIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetExternalIdActionQueryBuilderDsl>(p, CategorySetExternalIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetExternalIdActionQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<CategorySetExternalIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<CategorySetExternalIdActionQueryBuilderDsl>(p, CategorySetExternalIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
