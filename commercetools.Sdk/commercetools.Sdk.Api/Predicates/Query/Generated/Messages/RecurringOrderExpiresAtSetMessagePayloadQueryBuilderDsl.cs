using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl
    {
        public RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl Of()
        {
            return new RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl, DateTime> NewExpiresAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newExpiresAt")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl, DateTime> OldExpiresAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldExpiresAt")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
