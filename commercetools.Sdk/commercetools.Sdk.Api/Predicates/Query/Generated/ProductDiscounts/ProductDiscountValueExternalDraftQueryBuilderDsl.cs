using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountValueExternalDraftQueryBuilderDsl
    {
        public ProductDiscountValueExternalDraftQueryBuilderDsl()
        {
        }

        public static ProductDiscountValueExternalDraftQueryBuilderDsl Of()
        {
            return new ProductDiscountValueExternalDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountValueExternalDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductDiscountValueExternalDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductDiscountValueExternalDraftQueryBuilderDsl>(p, ProductDiscountValueExternalDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
