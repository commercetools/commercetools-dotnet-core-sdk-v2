// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl
    {
        public RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl()
        {
        }

        public static RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl Of()
        {
            return new RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl>(p, RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl, long> MinDaysBetweenOrders()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("minDaysBetweenOrders")),
            p => new CombinationQueryPredicate<RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl>(p, RecurrencePolicySetMinDaysBetweenOrdersActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
