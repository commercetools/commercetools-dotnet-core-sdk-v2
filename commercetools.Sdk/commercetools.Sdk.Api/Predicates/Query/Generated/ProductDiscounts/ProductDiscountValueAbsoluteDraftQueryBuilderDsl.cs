using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountValueAbsoluteDraftQueryBuilderDsl
    {
        public ProductDiscountValueAbsoluteDraftQueryBuilderDsl()
        {
        }

        public static ProductDiscountValueAbsoluteDraftQueryBuilderDsl Of()
        {
            return new ProductDiscountValueAbsoluteDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountValueAbsoluteDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductDiscountValueAbsoluteDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductDiscountValueAbsoluteDraftQueryBuilderDsl>(p, ProductDiscountValueAbsoluteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDiscountValueAbsoluteDraftQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountValueAbsoluteDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                ProductDiscountValueAbsoluteDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductDiscountValueAbsoluteDraftQueryBuilderDsl> Money()
        {
            return new CollectionPredicateBuilder<ProductDiscountValueAbsoluteDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("money")),
                    p => new CombinationQueryPredicate<ProductDiscountValueAbsoluteDraftQueryBuilderDsl>(p, ProductDiscountValueAbsoluteDraftQueryBuilderDsl.Of));
        }

    }
}
