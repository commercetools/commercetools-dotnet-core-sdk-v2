// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class DayOfMonthScheduleDraftQueryBuilderDsl
    {
        public DayOfMonthScheduleDraftQueryBuilderDsl()
        {
        }

        public static DayOfMonthScheduleDraftQueryBuilderDsl Of()
        {
            return new DayOfMonthScheduleDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DayOfMonthScheduleDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DayOfMonthScheduleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DayOfMonthScheduleDraftQueryBuilderDsl>(p, DayOfMonthScheduleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DayOfMonthScheduleDraftQueryBuilderDsl, long> Day()
        {
            return new ComparisonPredicateBuilder<DayOfMonthScheduleDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("day")),
            p => new CombinationQueryPredicate<DayOfMonthScheduleDraftQueryBuilderDsl>(p, DayOfMonthScheduleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
