using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetFirstNameActionQueryBuilderDsl
    {
        public MyCustomerSetFirstNameActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetFirstNameActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetFirstNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetFirstNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetFirstNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetFirstNameActionQueryBuilderDsl>(p, MyCustomerSetFirstNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetFirstNameActionQueryBuilderDsl, string> FirstName()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetFirstNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("firstName")),
            p => new CombinationQueryPredicate<MyCustomerSetFirstNameActionQueryBuilderDsl>(p, MyCustomerSetFirstNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
