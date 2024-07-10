using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountValueExternalQueryBuilderDsl
    {
        public ProductDiscountValueExternalQueryBuilderDsl()
        {
        }

        public static ProductDiscountValueExternalQueryBuilderDsl Of()
        {
            return new ProductDiscountValueExternalQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountValueExternalQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductDiscountValueExternalQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductDiscountValueExternalQueryBuilderDsl>(p, ProductDiscountValueExternalQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
