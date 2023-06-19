using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerGroups
{

    public partial class CustomerGroupPagedQueryResponseQueryBuilderDsl
    {
        public CustomerGroupPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static CustomerGroupPagedQueryResponseQueryBuilderDsl Of()
        {
            return new CustomerGroupPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<CustomerGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<CustomerGroupPagedQueryResponseQueryBuilderDsl>(p, CustomerGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<CustomerGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<CustomerGroupPagedQueryResponseQueryBuilderDsl>(p, CustomerGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<CustomerGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<CustomerGroupPagedQueryResponseQueryBuilderDsl>(p, CustomerGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<CustomerGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<CustomerGroupPagedQueryResponseQueryBuilderDsl>(p, CustomerGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupQueryBuilderDsl.Of())),
                CustomerGroupPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerGroupPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<CustomerGroupPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<CustomerGroupPagedQueryResponseQueryBuilderDsl>(p, CustomerGroupPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
