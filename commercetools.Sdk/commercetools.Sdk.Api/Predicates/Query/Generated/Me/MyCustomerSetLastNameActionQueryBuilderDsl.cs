using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetLastNameActionQueryBuilderDsl
    {
        public MyCustomerSetLastNameActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetLastNameActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetLastNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetLastNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetLastNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetLastNameActionQueryBuilderDsl>(p, MyCustomerSetLastNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetLastNameActionQueryBuilderDsl, string> LastName()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetLastNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastName")),
            p => new CombinationQueryPredicate<MyCustomerSetLastNameActionQueryBuilderDsl>(p, MyCustomerSetLastNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
