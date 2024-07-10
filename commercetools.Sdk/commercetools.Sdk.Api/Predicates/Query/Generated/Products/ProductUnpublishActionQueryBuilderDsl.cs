using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductUnpublishActionQueryBuilderDsl
    {
        public ProductUnpublishActionQueryBuilderDsl()
        {
        }

        public static ProductUnpublishActionQueryBuilderDsl Of()
        {
            return new ProductUnpublishActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductUnpublishActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductUnpublishActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductUnpublishActionQueryBuilderDsl>(p, ProductUnpublishActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
