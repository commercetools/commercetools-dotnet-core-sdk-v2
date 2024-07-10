using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetPriceKeyActionQueryBuilderDsl
    {
        public ProductSetPriceKeyActionQueryBuilderDsl()
        {
        }

        public static ProductSetPriceKeyActionQueryBuilderDsl Of()
        {
            return new ProductSetPriceKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetPriceKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetPriceKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetPriceKeyActionQueryBuilderDsl>(p, ProductSetPriceKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetPriceKeyActionQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductSetPriceKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductSetPriceKeyActionQueryBuilderDsl>(p, ProductSetPriceKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetPriceKeyActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetPriceKeyActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetPriceKeyActionQueryBuilderDsl>(p, ProductSetPriceKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetPriceKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductSetPriceKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductSetPriceKeyActionQueryBuilderDsl>(p, ProductSetPriceKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
