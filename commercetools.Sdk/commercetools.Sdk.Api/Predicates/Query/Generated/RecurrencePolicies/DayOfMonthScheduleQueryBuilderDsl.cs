// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class DayOfMonthScheduleQueryBuilderDsl
    {
        public DayOfMonthScheduleQueryBuilderDsl()
        {
        }

        public static DayOfMonthScheduleQueryBuilderDsl Of()
        {
            return new DayOfMonthScheduleQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DayOfMonthScheduleQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DayOfMonthScheduleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DayOfMonthScheduleQueryBuilderDsl>(p, DayOfMonthScheduleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DayOfMonthScheduleQueryBuilderDsl, long> Day()
        {
            return new ComparisonPredicateBuilder<DayOfMonthScheduleQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("day")),
            p => new CombinationQueryPredicate<DayOfMonthScheduleQueryBuilderDsl>(p, DayOfMonthScheduleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
