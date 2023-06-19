// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl
    {
        public DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl Of()
        {
            return new DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl>(p, DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl, long> MaxApplicationsPerCustomer()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxApplicationsPerCustomer")),
            p => new CombinationQueryPredicate<DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl>(p, DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
