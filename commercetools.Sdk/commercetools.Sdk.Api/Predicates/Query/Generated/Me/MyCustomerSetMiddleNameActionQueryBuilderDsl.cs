using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetMiddleNameActionQueryBuilderDsl
    {
        public MyCustomerSetMiddleNameActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetMiddleNameActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetMiddleNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetMiddleNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetMiddleNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetMiddleNameActionQueryBuilderDsl>(p, MyCustomerSetMiddleNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetMiddleNameActionQueryBuilderDsl, string> MiddleName()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetMiddleNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("middleName")),
            p => new CombinationQueryPredicate<MyCustomerSetMiddleNameActionQueryBuilderDsl>(p, MyCustomerSetMiddleNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
