// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetCustomerIdActionQueryBuilderDsl
    {
        public StagedOrderSetCustomerIdActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetCustomerIdActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetCustomerIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetCustomerIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCustomerIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetCustomerIdActionQueryBuilderDsl>(p, StagedOrderSetCustomerIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetCustomerIdActionQueryBuilderDsl, string> CustomerId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCustomerIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerId")),
            p => new CombinationQueryPredicate<StagedOrderSetCustomerIdActionQueryBuilderDsl>(p, StagedOrderSetCustomerIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
