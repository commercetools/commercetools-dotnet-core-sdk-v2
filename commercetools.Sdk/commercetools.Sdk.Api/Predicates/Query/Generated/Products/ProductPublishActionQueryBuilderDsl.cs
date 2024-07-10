using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductPublishActionQueryBuilderDsl
    {
        public ProductPublishActionQueryBuilderDsl()
        {
        }

        public static ProductPublishActionQueryBuilderDsl Of()
        {
            return new ProductPublishActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPublishActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductPublishActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductPublishActionQueryBuilderDsl>(p, ProductPublishActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPublishActionQueryBuilderDsl, string> Scope()
        {
            return new ComparisonPredicateBuilder<ProductPublishActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("scope")),
            p => new CombinationQueryPredicate<ProductPublishActionQueryBuilderDsl>(p, ProductPublishActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
