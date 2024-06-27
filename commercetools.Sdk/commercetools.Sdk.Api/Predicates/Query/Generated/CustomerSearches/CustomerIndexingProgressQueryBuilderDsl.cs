// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerSearches
{

    public partial class CustomerIndexingProgressQueryBuilderDsl
    {
        public CustomerIndexingProgressQueryBuilderDsl()
        {
        }

        public static CustomerIndexingProgressQueryBuilderDsl Of()
        {
            return new CustomerIndexingProgressQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerIndexingProgressQueryBuilderDsl, long> Indexed()
        {
            return new ComparisonPredicateBuilder<CustomerIndexingProgressQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("indexed")),
            p => new CombinationQueryPredicate<CustomerIndexingProgressQueryBuilderDsl>(p, CustomerIndexingProgressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerIndexingProgressQueryBuilderDsl, long> Failed()
        {
            return new ComparisonPredicateBuilder<CustomerIndexingProgressQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("failed")),
            p => new CombinationQueryPredicate<CustomerIndexingProgressQueryBuilderDsl>(p, CustomerIndexingProgressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerIndexingProgressQueryBuilderDsl, long> EstimatedTotal()
        {
            return new ComparisonPredicateBuilder<CustomerIndexingProgressQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("estimatedTotal")),
            p => new CombinationQueryPredicate<CustomerIndexingProgressQueryBuilderDsl>(p, CustomerIndexingProgressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
