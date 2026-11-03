using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl
    {
        public RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl()
        {
        }

        public static RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl Of()
        {
            return new RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl>(p, RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl, DateTime> RequestedAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("requestedAt")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl>(p, RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl, string> Reason()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reason")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl>(p, RecurringOrderNowRequestedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
