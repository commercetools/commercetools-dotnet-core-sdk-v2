using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditUpdateQueryBuilderDsl
    {
        public OrderEditUpdateQueryBuilderDsl()
        {
        }

        public static OrderEditUpdateQueryBuilderDsl Of()
        {
            return new OrderEditUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderEditUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderEditUpdateQueryBuilderDsl>(p, OrderEditUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditUpdateActionQueryBuilderDsl.Of())),
                OrderEditUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderEditUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<OrderEditUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<OrderEditUpdateQueryBuilderDsl>(p, OrderEditUpdateQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<OrderEditUpdateQueryBuilderDsl, bool> DryRun()
        {
            return new ComparisonPredicateBuilder<OrderEditUpdateQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dryRun")),
            p => new CombinationQueryPredicate<OrderEditUpdateQueryBuilderDsl>(p, OrderEditUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
