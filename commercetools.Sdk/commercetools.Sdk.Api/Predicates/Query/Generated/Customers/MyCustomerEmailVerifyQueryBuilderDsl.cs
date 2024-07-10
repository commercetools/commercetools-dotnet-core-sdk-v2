using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class MyCustomerEmailVerifyQueryBuilderDsl
    {
        public MyCustomerEmailVerifyQueryBuilderDsl()
        {
        }

        public static MyCustomerEmailVerifyQueryBuilderDsl Of()
        {
            return new MyCustomerEmailVerifyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerEmailVerifyQueryBuilderDsl, string> TokenValue()
        {
            return new ComparisonPredicateBuilder<MyCustomerEmailVerifyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tokenValue")),
            p => new CombinationQueryPredicate<MyCustomerEmailVerifyQueryBuilderDsl>(p, MyCustomerEmailVerifyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
