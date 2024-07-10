using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringUnpublishActionQueryBuilderDsl
    {
        public ProductTailoringUnpublishActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringUnpublishActionQueryBuilderDsl Of()
        {
            return new ProductTailoringUnpublishActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringUnpublishActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringUnpublishActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringUnpublishActionQueryBuilderDsl>(p, ProductTailoringUnpublishActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
