using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderReferenceQueryBuilderDsl
    {
        public OrderReferenceQueryBuilderDsl()
        {
        }

        public static OrderReferenceQueryBuilderDsl Of()
        {
            return new OrderReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<OrderReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<OrderReferenceQueryBuilderDsl>(p, OrderReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderReferenceQueryBuilderDsl>(p, OrderReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl.Of())),
                OrderReferenceQueryBuilderDsl.Of);
        }


    }
}
