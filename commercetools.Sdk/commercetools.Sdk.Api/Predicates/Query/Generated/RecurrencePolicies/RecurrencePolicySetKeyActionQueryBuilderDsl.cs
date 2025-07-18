// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicySetKeyActionQueryBuilderDsl
    {
        public RecurrencePolicySetKeyActionQueryBuilderDsl()
        {
        }

        public static RecurrencePolicySetKeyActionQueryBuilderDsl Of()
        {
            return new RecurrencePolicySetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicySetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicySetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurrencePolicySetKeyActionQueryBuilderDsl>(p, RecurrencePolicySetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurrencePolicySetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicySetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<RecurrencePolicySetKeyActionQueryBuilderDsl>(p, RecurrencePolicySetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
