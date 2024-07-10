using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartRemovePaymentActionQueryBuilderDsl
    {
        public MyCartRemovePaymentActionQueryBuilderDsl()
        {
        }

        public static MyCartRemovePaymentActionQueryBuilderDsl Of()
        {
            return new MyCartRemovePaymentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartRemovePaymentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartRemovePaymentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartRemovePaymentActionQueryBuilderDsl>(p, MyCartRemovePaymentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartRemovePaymentActionQueryBuilderDsl> Payment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartRemovePaymentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl.Of())),
                MyCartRemovePaymentActionQueryBuilderDsl.Of);
        }


    }
}
