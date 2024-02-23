using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSigninQueryBuilderDsl
    {
        public CustomerSigninQueryBuilderDsl()
        {
        }

        public static CustomerSigninQueryBuilderDsl Of()
        {
            return new CustomerSigninQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<CustomerSigninQueryBuilderDsl>(p, CustomerSigninQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, string> Password()
        {
            return new ComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("password")),
            p => new CombinationQueryPredicate<CustomerSigninQueryBuilderDsl>(p, CustomerSigninQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, string> AnonymousCartId()
        {
            return new ComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousCartId")),
            p => new CombinationQueryPredicate<CustomerSigninQueryBuilderDsl>(p, CustomerSigninQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerSigninQueryBuilderDsl> AnonymousCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerSigninQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("anonymousCart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl.Of())),
                CustomerSigninQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, string> AnonymousCartSignInMode()
        {
            return new ComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousCartSignInMode")),
            p => new CombinationQueryPredicate<CustomerSigninQueryBuilderDsl>(p, CustomerSigninQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<CustomerSigninQueryBuilderDsl>(p, CustomerSigninQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, bool> UpdateProductData()
        {
            return new ComparisonPredicateBuilder<CustomerSigninQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("updateProductData")),
            p => new CombinationQueryPredicate<CustomerSigninQueryBuilderDsl>(p, CustomerSigninQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
