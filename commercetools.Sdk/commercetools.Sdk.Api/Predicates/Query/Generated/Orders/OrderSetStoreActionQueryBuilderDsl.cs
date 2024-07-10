using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetStoreActionQueryBuilderDsl
    {
        public OrderSetStoreActionQueryBuilderDsl()
        {
        }

        public static OrderSetStoreActionQueryBuilderDsl Of()
        {
            return new OrderSetStoreActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetStoreActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetStoreActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetStoreActionQueryBuilderDsl>(p, OrderSetStoreActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetStoreActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetStoreActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                OrderSetStoreActionQueryBuilderDsl.Of);
        }


    }
}
