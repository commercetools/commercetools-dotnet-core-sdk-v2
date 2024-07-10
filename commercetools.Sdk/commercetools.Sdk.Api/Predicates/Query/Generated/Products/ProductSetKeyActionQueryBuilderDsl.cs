using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetKeyActionQueryBuilderDsl
    {
        public ProductSetKeyActionQueryBuilderDsl()
        {
        }

        public static ProductSetKeyActionQueryBuilderDsl Of()
        {
            return new ProductSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetKeyActionQueryBuilderDsl>(p, ProductSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductSetKeyActionQueryBuilderDsl>(p, ProductSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
