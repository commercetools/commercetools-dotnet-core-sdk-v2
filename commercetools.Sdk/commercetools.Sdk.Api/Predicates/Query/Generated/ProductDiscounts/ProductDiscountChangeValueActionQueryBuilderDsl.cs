using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountChangeValueActionQueryBuilderDsl
    {
        public ProductDiscountChangeValueActionQueryBuilderDsl()
        {
        }

        public static ProductDiscountChangeValueActionQueryBuilderDsl Of()
        {
            return new ProductDiscountChangeValueActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountChangeValueActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductDiscountChangeValueActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductDiscountChangeValueActionQueryBuilderDsl>(p, ProductDiscountChangeValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDiscountChangeValueActionQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountChangeValueActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountValueDraftQueryBuilderDsl.Of())),
                ProductDiscountChangeValueActionQueryBuilderDsl.Of);
        }


    }
}
