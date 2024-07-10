using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerUpdateQueryBuilderDsl
    {
        public CustomerUpdateQueryBuilderDsl()
        {
        }

        public static CustomerUpdateQueryBuilderDsl Of()
        {
            return new CustomerUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerUpdateQueryBuilderDsl>(p, CustomerUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerUpdateActionQueryBuilderDsl.Of())),
                CustomerUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<CustomerUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<CustomerUpdateQueryBuilderDsl>(p, CustomerUpdateQueryBuilderDsl.Of));
        }

    }
}
