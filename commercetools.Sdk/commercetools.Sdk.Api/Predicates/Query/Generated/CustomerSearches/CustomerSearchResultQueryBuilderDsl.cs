// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerSearches
{

    public partial class CustomerSearchResultQueryBuilderDsl
    {
        public CustomerSearchResultQueryBuilderDsl()
        {
        }

        public static CustomerSearchResultQueryBuilderDsl Of()
        {
            return new CustomerSearchResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSearchResultQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerSearchResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerSearchResultQueryBuilderDsl>(p, CustomerSearchResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSearchResultQueryBuilderDsl, decimal> Relevance()
        {
            return new ComparisonPredicateBuilder<CustomerSearchResultQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("relevance")),
            p => new CombinationQueryPredicate<CustomerSearchResultQueryBuilderDsl>(p, CustomerSearchResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
