using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductReferenceQueryBuilderDsl
    {
        public ProductReferenceQueryBuilderDsl()
        {
        }

        public static ProductReferenceQueryBuilderDsl Of()
        {
            return new ProductReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ProductReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ProductReferenceQueryBuilderDsl>(p, ProductReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductReferenceQueryBuilderDsl>(p, ProductReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductQueryBuilderDsl.Of())),
                ProductReferenceQueryBuilderDsl.Of);
        }


    }
}
