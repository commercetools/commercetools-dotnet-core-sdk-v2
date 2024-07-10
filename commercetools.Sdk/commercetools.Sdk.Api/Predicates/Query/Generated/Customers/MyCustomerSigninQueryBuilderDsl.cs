using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class MyCustomerSigninQueryBuilderDsl
    {
        public MyCustomerSigninQueryBuilderDsl()
        {
        }

        public static MyCustomerSigninQueryBuilderDsl Of()
        {
            return new MyCustomerSigninQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSigninQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<MyCustomerSigninQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<MyCustomerSigninQueryBuilderDsl>(p, MyCustomerSigninQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSigninQueryBuilderDsl, string> Password()
        {
            return new ComparisonPredicateBuilder<MyCustomerSigninQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("password")),
            p => new CombinationQueryPredicate<MyCustomerSigninQueryBuilderDsl>(p, MyCustomerSigninQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSigninQueryBuilderDsl, string> ActiveCartSignInMode()
        {
            return new ComparisonPredicateBuilder<MyCustomerSigninQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("activeCartSignInMode")),
            p => new CombinationQueryPredicate<MyCustomerSigninQueryBuilderDsl>(p, MyCustomerSigninQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSigninQueryBuilderDsl, bool> UpdateProductData()
        {
            return new ComparisonPredicateBuilder<MyCustomerSigninQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("updateProductData")),
            p => new CombinationQueryPredicate<MyCustomerSigninQueryBuilderDsl>(p, MyCustomerSigninQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
