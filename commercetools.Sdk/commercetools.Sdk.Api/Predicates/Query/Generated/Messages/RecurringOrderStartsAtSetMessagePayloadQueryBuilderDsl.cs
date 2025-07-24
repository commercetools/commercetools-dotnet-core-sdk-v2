using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl
    {
        public RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl Of()
        {
            return new RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl>(p, RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl, DateTime> StartsAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("startsAt")),
            p => new CombinationQueryPredicate<RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl>(p, RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl, DateTime> OldStartsAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldStartsAt")),
            p => new CombinationQueryPredicate<RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl>(p, RecurringOrderStartsAtSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
