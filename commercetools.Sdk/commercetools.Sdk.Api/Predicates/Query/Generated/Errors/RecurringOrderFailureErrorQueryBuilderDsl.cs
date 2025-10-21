// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class RecurringOrderFailureErrorQueryBuilderDsl
    {
        public RecurringOrderFailureErrorQueryBuilderDsl()
        {
        }

        public static RecurringOrderFailureErrorQueryBuilderDsl Of()
        {
            return new RecurringOrderFailureErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderFailureErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailureErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<RecurringOrderFailureErrorQueryBuilderDsl>(p, RecurringOrderFailureErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailureErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailureErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<RecurringOrderFailureErrorQueryBuilderDsl>(p, RecurringOrderFailureErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailureErrorQueryBuilderDsl, string> Details()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailureErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("details")),
            p => new CombinationQueryPredicate<RecurringOrderFailureErrorQueryBuilderDsl>(p, RecurringOrderFailureErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
