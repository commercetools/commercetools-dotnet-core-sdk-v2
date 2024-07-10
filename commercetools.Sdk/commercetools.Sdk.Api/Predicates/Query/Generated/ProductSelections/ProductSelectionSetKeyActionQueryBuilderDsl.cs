using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionSetKeyActionQueryBuilderDsl
    {
        public ProductSelectionSetKeyActionQueryBuilderDsl()
        {
        }

        public static ProductSelectionSetKeyActionQueryBuilderDsl Of()
        {
            return new ProductSelectionSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSelectionSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSelectionSetKeyActionQueryBuilderDsl>(p, ProductSelectionSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSelectionSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductSelectionSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductSelectionSetKeyActionQueryBuilderDsl>(p, ProductSelectionSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
