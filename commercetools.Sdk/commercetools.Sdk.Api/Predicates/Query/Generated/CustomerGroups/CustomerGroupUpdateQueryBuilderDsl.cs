using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerGroups
{

    public partial class CustomerGroupUpdateQueryBuilderDsl
    {
        public CustomerGroupUpdateQueryBuilderDsl()
        {
        }

        public static CustomerGroupUpdateQueryBuilderDsl Of()
        {
            return new CustomerGroupUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerGroupUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerGroupUpdateQueryBuilderDsl>(p, CustomerGroupUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupUpdateActionQueryBuilderDsl.Of())),
                CustomerGroupUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerGroupUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<CustomerGroupUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<CustomerGroupUpdateQueryBuilderDsl>(p, CustomerGroupUpdateQueryBuilderDsl.Of));
        }

    }
}
