using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentReferenceQueryBuilderDsl
    {
        public PaymentReferenceQueryBuilderDsl()
        {
        }

        public static PaymentReferenceQueryBuilderDsl Of()
        {
            return new PaymentReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<PaymentReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<PaymentReferenceQueryBuilderDsl>(p, PaymentReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<PaymentReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<PaymentReferenceQueryBuilderDsl>(p, PaymentReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl.Of())),
                PaymentReferenceQueryBuilderDsl.Of);
        }


    }
}
