// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class RecurringOrderStateChangedMessagePayloadQueryBuilderDsl
    {
        public RecurringOrderStateChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static RecurringOrderStateChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new RecurringOrderStateChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderStateChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderStateChangedMessagePayloadQueryBuilderDsl>(p, RecurringOrderStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderStateChangedMessagePayloadQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<RecurringOrderStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<RecurringOrderStateChangedMessagePayloadQueryBuilderDsl>(p, RecurringOrderStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderStateChangedMessagePayloadQueryBuilderDsl, string> OldState()
        {
            return new ComparisonPredicateBuilder<RecurringOrderStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldState")),
            p => new CombinationQueryPredicate<RecurringOrderStateChangedMessagePayloadQueryBuilderDsl>(p, RecurringOrderStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
