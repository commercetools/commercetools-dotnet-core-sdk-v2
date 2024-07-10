using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeUpdateQueryBuilderDsl
    {
        public ProductTypeUpdateQueryBuilderDsl()
        {
        }

        public static ProductTypeUpdateQueryBuilderDsl Of()
        {
            return new ProductTypeUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductTypeUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductTypeUpdateQueryBuilderDsl>(p, ProductTypeUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypeUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeUpdateActionQueryBuilderDsl.Of())),
                ProductTypeUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductTypeUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ProductTypeUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ProductTypeUpdateQueryBuilderDsl>(p, ProductTypeUpdateQueryBuilderDsl.Of));
        }

    }
}
