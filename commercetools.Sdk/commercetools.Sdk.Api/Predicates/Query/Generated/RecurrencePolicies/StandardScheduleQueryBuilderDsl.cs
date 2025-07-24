// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class StandardScheduleQueryBuilderDsl
    {
        public StandardScheduleQueryBuilderDsl()
        {
        }

        public static StandardScheduleQueryBuilderDsl Of()
        {
            return new StandardScheduleQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandardScheduleQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandardScheduleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandardScheduleQueryBuilderDsl>(p, StandardScheduleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandardScheduleQueryBuilderDsl, long> Value()
        {
            return new ComparisonPredicateBuilder<StandardScheduleQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<StandardScheduleQueryBuilderDsl>(p, StandardScheduleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandardScheduleQueryBuilderDsl, string> IntervalUnit()
        {
            return new ComparisonPredicateBuilder<StandardScheduleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("intervalUnit")),
            p => new CombinationQueryPredicate<StandardScheduleQueryBuilderDsl>(p, StandardScheduleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
