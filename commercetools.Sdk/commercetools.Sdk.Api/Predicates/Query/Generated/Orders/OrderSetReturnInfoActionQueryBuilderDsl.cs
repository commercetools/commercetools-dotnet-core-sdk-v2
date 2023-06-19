using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetReturnInfoActionQueryBuilderDsl
    {
        public OrderSetReturnInfoActionQueryBuilderDsl()
        {
        }

        public static OrderSetReturnInfoActionQueryBuilderDsl Of()
        {
            return new OrderSetReturnInfoActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetReturnInfoActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetReturnInfoActionQueryBuilderDsl>(p, OrderSetReturnInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetReturnInfoActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetReturnInfoActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoDraftQueryBuilderDsl.Of())),
                OrderSetReturnInfoActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderSetReturnInfoActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<OrderSetReturnInfoActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<OrderSetReturnInfoActionQueryBuilderDsl>(p, OrderSetReturnInfoActionQueryBuilderDsl.Of));
        }

    }
}
