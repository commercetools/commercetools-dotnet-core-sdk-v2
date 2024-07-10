// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerResourceIdentifierQueryBuilderDsl
    {
        public CustomerResourceIdentifierQueryBuilderDsl()
        {
        }

        public static CustomerResourceIdentifierQueryBuilderDsl Of()
        {
            return new CustomerResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<CustomerResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<CustomerResourceIdentifierQueryBuilderDsl>(p, CustomerResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerResourceIdentifierQueryBuilderDsl>(p, CustomerResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomerResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomerResourceIdentifierQueryBuilderDsl>(p, CustomerResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
