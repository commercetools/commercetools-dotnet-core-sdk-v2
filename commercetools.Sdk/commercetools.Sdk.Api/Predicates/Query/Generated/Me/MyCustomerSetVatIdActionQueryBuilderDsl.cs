using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetVatIdActionQueryBuilderDsl
    {
        public MyCustomerSetVatIdActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetVatIdActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetVatIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetVatIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetVatIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetVatIdActionQueryBuilderDsl>(p, MyCustomerSetVatIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetVatIdActionQueryBuilderDsl, string> VatId()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetVatIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("vatId")),
            p => new CombinationQueryPredicate<MyCustomerSetVatIdActionQueryBuilderDsl>(p, MyCustomerSetVatIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
