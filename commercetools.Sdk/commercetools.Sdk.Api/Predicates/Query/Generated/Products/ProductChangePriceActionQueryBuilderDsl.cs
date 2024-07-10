using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductChangePriceActionQueryBuilderDsl
    {
        public ProductChangePriceActionQueryBuilderDsl()
        {
        }

        public static ProductChangePriceActionQueryBuilderDsl Of()
        {
            return new ProductChangePriceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductChangePriceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductChangePriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductChangePriceActionQueryBuilderDsl>(p, ProductChangePriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangePriceActionQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductChangePriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductChangePriceActionQueryBuilderDsl>(p, ProductChangePriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductChangePriceActionQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductChangePriceActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl.Of())),
                ProductChangePriceActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductChangePriceActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductChangePriceActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductChangePriceActionQueryBuilderDsl>(p, ProductChangePriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
