using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class RecurringOrderFailedMessagePayloadQueryBuilderDsl
    {
        public RecurringOrderFailedMessagePayloadQueryBuilderDsl()
        {
        }

        public static RecurringOrderFailedMessagePayloadQueryBuilderDsl Of()
        {
            return new RecurringOrderFailedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessagePayloadQueryBuilderDsl>(p, RecurringOrderFailedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl, string> CartId()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartId")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessagePayloadQueryBuilderDsl>(p, RecurringOrderFailedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl, DateTime> FailedAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("failedAt")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessagePayloadQueryBuilderDsl>(p, RecurringOrderFailedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl, string> FailureReason()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("failureReason")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessagePayloadQueryBuilderDsl>(p, RecurringOrderFailedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl, DateTime> OrderScheduledAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderScheduledAt")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessagePayloadQueryBuilderDsl>(p, RecurringOrderFailedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderFailedMessagePayloadQueryBuilderDsl> Errors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.RecurringOrderFailureErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.RecurringOrderFailureErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderFailedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.RecurringOrderFailureErrorQueryBuilderDsl.Of())),
                RecurringOrderFailedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl> Errors()
        {
            return new CollectionPredicateBuilder<RecurringOrderFailedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("errors")),
                    p => new CombinationQueryPredicate<RecurringOrderFailedMessagePayloadQueryBuilderDsl>(p, RecurringOrderFailedMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
