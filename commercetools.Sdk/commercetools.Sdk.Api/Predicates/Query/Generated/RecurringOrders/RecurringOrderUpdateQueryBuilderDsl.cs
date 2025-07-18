using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderUpdateQueryBuilderDsl
    {
        public RecurringOrderUpdateQueryBuilderDsl()
        {
        }

        public static RecurringOrderUpdateQueryBuilderDsl Of()
        {
            return new RecurringOrderUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<RecurringOrderUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<RecurringOrderUpdateQueryBuilderDsl>(p, RecurringOrderUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderUpdateActionQueryBuilderDsl.Of())),
                RecurringOrderUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<RecurringOrderUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<RecurringOrderUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<RecurringOrderUpdateQueryBuilderDsl>(p, RecurringOrderUpdateQueryBuilderDsl.Of));
        }

    }
}
