using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderReferenceQueryBuilderDsl
    {
        public RecurringOrderReferenceQueryBuilderDsl()
        {
        }

        public static RecurringOrderReferenceQueryBuilderDsl Of()
        {
            return new RecurringOrderReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<RecurringOrderReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<RecurringOrderReferenceQueryBuilderDsl>(p, RecurringOrderReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<RecurringOrderReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<RecurringOrderReferenceQueryBuilderDsl>(p, RecurringOrderReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderQueryBuilderDsl.Of())),
                RecurringOrderReferenceQueryBuilderDsl.Of);
        }


    }
}
