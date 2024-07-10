using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionRemoveProductActionQueryBuilderDsl
    {
        public ProductSelectionRemoveProductActionQueryBuilderDsl()
        {
        }

        public static ProductSelectionRemoveProductActionQueryBuilderDsl Of()
        {
            return new ProductSelectionRemoveProductActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionRemoveProductActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSelectionRemoveProductActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSelectionRemoveProductActionQueryBuilderDsl>(p, ProductSelectionRemoveProductActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionRemoveProductActionQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionRemoveProductActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl.Of())),
                ProductSelectionRemoveProductActionQueryBuilderDsl.Of);
        }


    }
}
