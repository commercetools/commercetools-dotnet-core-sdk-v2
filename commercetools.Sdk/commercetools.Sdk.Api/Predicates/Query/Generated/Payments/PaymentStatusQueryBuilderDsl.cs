using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentStatusQueryBuilderDsl
    {
        public PaymentStatusQueryBuilderDsl()
        {
        }

        public static PaymentStatusQueryBuilderDsl Of()
        {
            return new PaymentStatusQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentStatusQueryBuilderDsl, string> InterfaceCode()
        {
            return new ComparisonPredicateBuilder<PaymentStatusQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceCode")),
            p => new CombinationQueryPredicate<PaymentStatusQueryBuilderDsl>(p, PaymentStatusQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusQueryBuilderDsl, string> InterfaceText()
        {
            return new ComparisonPredicateBuilder<PaymentStatusQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceText")),
            p => new CombinationQueryPredicate<PaymentStatusQueryBuilderDsl>(p, PaymentStatusQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentStatusQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                PaymentStatusQueryBuilderDsl.Of);
        }


    }
}
