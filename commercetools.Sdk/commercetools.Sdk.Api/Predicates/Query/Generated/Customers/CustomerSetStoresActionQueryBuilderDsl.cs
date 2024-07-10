using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetStoresActionQueryBuilderDsl
    {
        public CustomerSetStoresActionQueryBuilderDsl()
        {
        }

        public static CustomerSetStoresActionQueryBuilderDsl Of()
        {
            return new CustomerSetStoresActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetStoresActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetStoresActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetStoresActionQueryBuilderDsl>(p, CustomerSetStoresActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerSetStoresActionQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerSetStoresActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CustomerSetStoresActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerSetStoresActionQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<CustomerSetStoresActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<CustomerSetStoresActionQueryBuilderDsl>(p, CustomerSetStoresActionQueryBuilderDsl.Of));
        }

    }
}
