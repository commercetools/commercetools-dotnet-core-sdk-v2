using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerRemoveStoreActionQueryBuilderDsl
    {
        public CustomerRemoveStoreActionQueryBuilderDsl()
        {
        }

        public static CustomerRemoveStoreActionQueryBuilderDsl Of()
        {
            return new CustomerRemoveStoreActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerRemoveStoreActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerRemoveStoreActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerRemoveStoreActionQueryBuilderDsl>(p, CustomerRemoveStoreActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerRemoveStoreActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerRemoveStoreActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CustomerRemoveStoreActionQueryBuilderDsl.Of);
        }


    }
}
