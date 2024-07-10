using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountChangeNameActionQueryBuilderDsl
    {
        public ProductDiscountChangeNameActionQueryBuilderDsl()
        {
        }

        public static ProductDiscountChangeNameActionQueryBuilderDsl Of()
        {
            return new ProductDiscountChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductDiscountChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductDiscountChangeNameActionQueryBuilderDsl>(p, ProductDiscountChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDiscountChangeNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountChangeNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDiscountChangeNameActionQueryBuilderDsl.Of);
        }


    }
}
