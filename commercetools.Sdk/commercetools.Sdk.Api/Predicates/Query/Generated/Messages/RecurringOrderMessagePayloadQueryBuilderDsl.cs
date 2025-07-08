// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class RecurringOrderMessagePayloadQueryBuilderDsl
    {
        public RecurringOrderMessagePayloadQueryBuilderDsl()
        {
        }

        public static RecurringOrderMessagePayloadQueryBuilderDsl Of()
        {
            return new RecurringOrderMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderMessagePayloadQueryBuilderDsl>(p, RecurringOrderMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
