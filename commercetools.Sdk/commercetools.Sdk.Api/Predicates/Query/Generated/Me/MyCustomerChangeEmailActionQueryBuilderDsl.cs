using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerChangeEmailActionQueryBuilderDsl
    {
        public MyCustomerChangeEmailActionQueryBuilderDsl()
        {
        }

        public static MyCustomerChangeEmailActionQueryBuilderDsl Of()
        {
            return new MyCustomerChangeEmailActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerChangeEmailActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerChangeEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerChangeEmailActionQueryBuilderDsl>(p, MyCustomerChangeEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerChangeEmailActionQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<MyCustomerChangeEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<MyCustomerChangeEmailActionQueryBuilderDsl>(p, MyCustomerChangeEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
