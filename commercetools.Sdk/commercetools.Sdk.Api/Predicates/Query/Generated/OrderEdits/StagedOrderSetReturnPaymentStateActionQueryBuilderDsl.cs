using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetReturnPaymentStateActionQueryBuilderDsl
    {
        public StagedOrderSetReturnPaymentStateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetReturnPaymentStateActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetReturnPaymentStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl>(p, StagedOrderSetReturnPaymentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl, string> ReturnItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemId")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl>(p, StagedOrderSetReturnPaymentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl, string> ReturnItemKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemKey")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl>(p, StagedOrderSetReturnPaymentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnPaymentStateActionQueryBuilderDsl>(p, StagedOrderSetReturnPaymentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
