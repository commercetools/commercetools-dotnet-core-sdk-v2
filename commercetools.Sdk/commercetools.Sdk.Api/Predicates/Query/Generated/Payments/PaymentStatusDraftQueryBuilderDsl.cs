using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentStatusDraftQueryBuilderDsl
    {
        public PaymentStatusDraftQueryBuilderDsl()
        {
        }

        public static PaymentStatusDraftQueryBuilderDsl Of()
        {
            return new PaymentStatusDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentStatusDraftQueryBuilderDsl, string> InterfaceCode()
        {
            return new ComparisonPredicateBuilder<PaymentStatusDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceCode")),
            p => new CombinationQueryPredicate<PaymentStatusDraftQueryBuilderDsl>(p, PaymentStatusDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusDraftQueryBuilderDsl, string> InterfaceText()
        {
            return new ComparisonPredicateBuilder<PaymentStatusDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceText")),
            p => new CombinationQueryPredicate<PaymentStatusDraftQueryBuilderDsl>(p, PaymentStatusDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentStatusDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                PaymentStatusDraftQueryBuilderDsl.Of);
        }


    }
}
