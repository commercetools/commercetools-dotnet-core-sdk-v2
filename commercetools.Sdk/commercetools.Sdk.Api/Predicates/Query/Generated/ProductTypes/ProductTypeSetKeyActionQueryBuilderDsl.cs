using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeSetKeyActionQueryBuilderDsl
    {
        public ProductTypeSetKeyActionQueryBuilderDsl()
        {
        }

        public static ProductTypeSetKeyActionQueryBuilderDsl Of()
        {
            return new ProductTypeSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeSetKeyActionQueryBuilderDsl>(p, ProductTypeSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductTypeSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductTypeSetKeyActionQueryBuilderDsl>(p, ProductTypeSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
