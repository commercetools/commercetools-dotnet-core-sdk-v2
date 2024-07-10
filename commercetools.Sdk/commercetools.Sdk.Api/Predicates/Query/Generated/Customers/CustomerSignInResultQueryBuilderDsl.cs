using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSignInResultQueryBuilderDsl
    {
        public CustomerSignInResultQueryBuilderDsl()
        {
        }

        public static CustomerSignInResultQueryBuilderDsl Of()
        {
            return new CustomerSignInResultQueryBuilderDsl();
        }

        public CombinationQueryPredicate<CustomerSignInResultQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerSignInResultQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl.Of())),
                CustomerSignInResultQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerSignInResultQueryBuilderDsl> Cart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerSignInResultQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl.Of())),
                CustomerSignInResultQueryBuilderDsl.Of);
        }


    }
}
