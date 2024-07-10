using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetLocaleActionQueryBuilderDsl
    {
        public MyCustomerSetLocaleActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetLocaleActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetLocaleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetLocaleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetLocaleActionQueryBuilderDsl>(p, MyCustomerSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetLocaleActionQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<MyCustomerSetLocaleActionQueryBuilderDsl>(p, MyCustomerSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
