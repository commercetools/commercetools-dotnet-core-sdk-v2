using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ProductTailoringUpdateQueryBuilderDsl
    {
        public ProductTailoringUpdateQueryBuilderDsl()
        {
        }

        public static ProductTailoringUpdateQueryBuilderDsl Of()
        {
            return new ProductTailoringUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductTailoringUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductTailoringUpdateQueryBuilderDsl>(p, ProductTailoringUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringUpdateActionQueryBuilderDsl.Of())),
                ProductTailoringUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductTailoringUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ProductTailoringUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ProductTailoringUpdateQueryBuilderDsl>(p, ProductTailoringUpdateQueryBuilderDsl.Of));
        }

    }
}
