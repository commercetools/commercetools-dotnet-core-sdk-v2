using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderExcerptQueryBuilderDsl
    {
        public OrderExcerptQueryBuilderDsl()
        {
        }

        public static OrderExcerptQueryBuilderDsl Of()
        {
            return new OrderExcerptQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderExcerptQueryBuilderDsl> TotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderExcerptQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                OrderExcerptQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderExcerptQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderExcerptQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl.Of())),
                OrderExcerptQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderExcerptQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderExcerptQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderExcerptQueryBuilderDsl>(p, OrderExcerptQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
