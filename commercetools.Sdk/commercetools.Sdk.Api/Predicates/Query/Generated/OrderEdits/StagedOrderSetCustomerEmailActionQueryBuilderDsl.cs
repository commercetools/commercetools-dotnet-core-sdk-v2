// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetCustomerEmailActionQueryBuilderDsl
    {
        public StagedOrderSetCustomerEmailActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetCustomerEmailActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetCustomerEmailActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetCustomerEmailActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCustomerEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetCustomerEmailActionQueryBuilderDsl>(p, StagedOrderSetCustomerEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetCustomerEmailActionQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCustomerEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<StagedOrderSetCustomerEmailActionQueryBuilderDsl>(p, StagedOrderSetCustomerEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
