using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerTokenQueryBuilderDsl
    {
        public CustomerTokenQueryBuilderDsl()
        {
        }

        public static CustomerTokenQueryBuilderDsl Of()
        {
            return new CustomerTokenQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerTokenQueryBuilderDsl>(p, CustomerTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, string> CustomerId()
        {
            return new ComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerId")),
            p => new CombinationQueryPredicate<CustomerTokenQueryBuilderDsl>(p, CustomerTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomerTokenQueryBuilderDsl>(p, CustomerTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, DateTime> ExpiresAt()
        {
            return new ComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("expiresAt")),
            p => new CombinationQueryPredicate<CustomerTokenQueryBuilderDsl>(p, CustomerTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, bool> InvalidateOlderTokens()
        {
            return new ComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("invalidateOlderTokens")),
            p => new CombinationQueryPredicate<CustomerTokenQueryBuilderDsl>(p, CustomerTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomerTokenQueryBuilderDsl>(p, CustomerTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomerTokenQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomerTokenQueryBuilderDsl>(p, CustomerTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
