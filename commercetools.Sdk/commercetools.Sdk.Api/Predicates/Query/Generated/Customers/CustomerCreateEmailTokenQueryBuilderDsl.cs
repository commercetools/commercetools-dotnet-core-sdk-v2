// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerCreateEmailTokenQueryBuilderDsl
    {
        public CustomerCreateEmailTokenQueryBuilderDsl()
        {
        }

        public static CustomerCreateEmailTokenQueryBuilderDsl Of()
        {
            return new CustomerCreateEmailTokenQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerCreateEmailTokenQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerCreateEmailTokenQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerCreateEmailTokenQueryBuilderDsl>(p, CustomerCreateEmailTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCreateEmailTokenQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerCreateEmailTokenQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerCreateEmailTokenQueryBuilderDsl>(p, CustomerCreateEmailTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCreateEmailTokenQueryBuilderDsl, long> TtlMinutes()
        {
            return new ComparisonPredicateBuilder<CustomerCreateEmailTokenQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("ttlMinutes")),
            p => new CombinationQueryPredicate<CustomerCreateEmailTokenQueryBuilderDsl>(p, CustomerCreateEmailTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
