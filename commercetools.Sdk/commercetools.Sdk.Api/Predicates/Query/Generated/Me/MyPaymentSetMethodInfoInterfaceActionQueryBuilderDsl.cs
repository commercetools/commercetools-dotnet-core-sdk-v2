using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl
    {
        public MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl()
        {
        }

        public static MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl Of()
        {
            return new MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl>(p, MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl, string> Interface()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interface")),
            p => new CombinationQueryPredicate<MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl>(p, MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
