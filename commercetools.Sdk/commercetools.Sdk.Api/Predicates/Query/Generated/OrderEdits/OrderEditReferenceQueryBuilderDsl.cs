using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditReferenceQueryBuilderDsl
    {
        public OrderEditReferenceQueryBuilderDsl()
        {
        }

        public static OrderEditReferenceQueryBuilderDsl Of()
        {
            return new OrderEditReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<OrderEditReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<OrderEditReferenceQueryBuilderDsl>(p, OrderEditReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderEditReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderEditReferenceQueryBuilderDsl>(p, OrderEditReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl.Of())),
                OrderEditReferenceQueryBuilderDsl.Of);
        }


    }
}
