using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionUpdateQueryBuilderDsl
    {
        public ProductSelectionUpdateQueryBuilderDsl()
        {
        }

        public static ProductSelectionUpdateQueryBuilderDsl Of()
        {
            return new ProductSelectionUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductSelectionUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductSelectionUpdateQueryBuilderDsl>(p, ProductSelectionUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionUpdateActionQueryBuilderDsl.Of())),
                ProductSelectionUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSelectionUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ProductSelectionUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ProductSelectionUpdateQueryBuilderDsl>(p, ProductSelectionUpdateQueryBuilderDsl.Of));
        }

    }
}
