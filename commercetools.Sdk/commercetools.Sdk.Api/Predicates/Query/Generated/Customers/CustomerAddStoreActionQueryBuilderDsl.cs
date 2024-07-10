using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerAddStoreActionQueryBuilderDsl
    {
        public CustomerAddStoreActionQueryBuilderDsl()
        {
        }

        public static CustomerAddStoreActionQueryBuilderDsl Of()
        {
            return new CustomerAddStoreActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddStoreActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerAddStoreActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerAddStoreActionQueryBuilderDsl>(p, CustomerAddStoreActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddStoreActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddStoreActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CustomerAddStoreActionQueryBuilderDsl.Of);
        }


    }
}
