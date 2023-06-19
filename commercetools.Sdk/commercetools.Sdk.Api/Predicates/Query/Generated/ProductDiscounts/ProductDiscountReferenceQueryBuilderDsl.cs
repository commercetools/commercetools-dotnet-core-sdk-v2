using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountReferenceQueryBuilderDsl
    {
        public ProductDiscountReferenceQueryBuilderDsl()
        {
        }

        public static ProductDiscountReferenceQueryBuilderDsl Of()
        {
            return new ProductDiscountReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ProductDiscountReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ProductDiscountReferenceQueryBuilderDsl>(p, ProductDiscountReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductDiscountReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductDiscountReferenceQueryBuilderDsl>(p, ProductDiscountReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDiscountReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountQueryBuilderDsl.Of())),
                ProductDiscountReferenceQueryBuilderDsl.Of);
        }


    }
}
