using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderAddPaymentActionQueryBuilderDsl
    {
        public StagedOrderAddPaymentActionQueryBuilderDsl()
        {
        }

        public static StagedOrderAddPaymentActionQueryBuilderDsl Of()
        {
            return new StagedOrderAddPaymentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderAddPaymentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddPaymentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderAddPaymentActionQueryBuilderDsl>(p, StagedOrderAddPaymentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderAddPaymentActionQueryBuilderDsl> Payment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddPaymentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderAddPaymentActionQueryBuilderDsl.Of);
        }


    }
}
